using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using Npgsql;
using TransactionAPI.Models;

namespace TransactionAPI.Controllers
{
    public class ValuesController : ApiController
    {
        BancoDados BD = new BancoDados();
        BancoPostgre Banco = new BancoPostgre();
        // GET: api/values
        public DataTable Get()
        {
            Banco.SQL = "SELECT * FROM employees;";
            return Banco.ObterDataTable();
        }

        // GET: api/values
        public DataTable Get(int id)
        {
            Banco.SQL = "SELECT * FROM employees WHERE id=@id;";
            Banco.AddParametros("@id", id);
            return Banco.ObterDataTable();
        }

        // POST: api/values
        [HttpPost]
        public IHttpActionResult MyAction([FromBody]Employee empregado)
        {
            try
            {
                Banco.Begin();

                // For example:
                Banco.SQL = @"INSERT INTO employees 
                                            (firstname, lastname, gender, salary) 
                                            VALUES 
                                            (@firstname, @lastname, @gender, @salary);";

                Banco.AddParametros("@firstname", empregado.FirstName);
                Banco.AddParametros("@lastname", empregado.LastName);
                Banco.AddParametros("@gender", empregado.Gender);
                Banco.AddParametros("@salary", empregado.Salary);

                Banco.ExecutarSQL();

                // Commit the transaction if all operations succeed
                Banco.Commit();

                return Ok("Dados inseridos com sucesso.");
            }
            catch (Exception ex)
            {
                // Rollback the transaction if any operation fails
                Banco.Rollback();
                return InternalServerError(ex);
            }
            finally
            {
                Banco.Dispose();
            }
        }

        // PUT: api/values
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/values
        public void Delete(int id)
        {
        }
    }
}

