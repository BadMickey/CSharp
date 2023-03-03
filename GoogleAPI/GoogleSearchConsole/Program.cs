using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Customsearch.v1;
using Google.Apis.Services;
using Newtonsoft.Json;
using System.IO;

namespace GoogleSearchConsole
{
    public class ResultadoGoogle
    {
        public string cacheId { get; set; }
        public string displayLink { get; set; }
        public object fileFormat { get; set; }
        public string formattedUrl { get; set; }
        public string htmlFormattedUrl { get; set; }
        public string htmlSnippet { get; set; }
        public string htmlTitle { get; set; }
        public object image { get; set; }
        public string kind { get; set; }
        public object labels { get; set; }
        public string link { get; set; }
        public object mime { get; set; }
        public string snippet { get; set; }
        public string title { get; set; }
        public object ETag { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //BuscarProdutos();
            BuscarClientes();

            //string query = Console.ReadLine();
            //CustomsearchService customsearchService = new CustomsearchService(new BaseClientService.Initializer
            //{
            //    ApplicationName = "GoogleAPI",
            //    ApiKey = "key da api"
            //});

            //var searchRequest = customsearchService.Cse.List();


            //searchRequest.Cx = "a08a16e5fd98c490c";
            //searchRequest.Q = query;

            //var searchResponse = searchRequest.ExecuteAsync();
            //var resultado = (searchResponse.Result).Items;

            //var testejson = JsonConvert.SerializeObject(resultado);
            //List<ResultadoGoogle> lista = JsonConvert.DeserializeObject<List<ResultadoGoogle>>(testejson);

            //foreach (ResultadoGoogle r in lista)
            //    Console.WriteLine(r.displayLink);

            Console.Read();
        }

        public static void BuscarProdutos()
        {
            string TokenSV = "token da sv";

            HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create("https://api.suasvendas.com/v2/Produto");

            requisicao.Method = "GET";
            requisicao.ContentType = "application/json";
            requisicao.Headers.Add("Token", TokenSV);

            HttpWebResponse resposta = (HttpWebResponse)requisicao.GetResponse();
            if(resposta.StatusCode == HttpStatusCode.OK)
            {
                Stream stream = resposta.GetResponseStream();
                StreamReader streamReader = new StreamReader(stream);
                string json = streamReader.ReadToEnd();

                List<Model.Produto> listaProduto = new List<Model.Produto>();
                listaProduto = JsonConvert.DeserializeObject<List<Model.Produto>>(json);
                //Model.Produto produtoUnico = JsonConvert.DeserializeObject<Model.Produto>(json);

                listaProduto = listaProduto.OrderBy(produto => produto.prod_descricao).ToList();

                BuscarNoGoogle(listaProduto[0].prod_descricao);
            }
        }

        public static void BuscarClientes()
        {
            string TokenSV = "token da sv";

            HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create("https://api.suasvendas.com/v2/Cliente");

            requisicao.Method = "GET";
            requisicao.ContentType = "application/json";
            requisicao.Headers.Add("Token", TokenSV);

            HttpWebResponse resposta = (HttpWebResponse)requisicao.GetResponse();
            if (resposta.StatusCode == HttpStatusCode.OK)
            {
                Stream stream = resposta.GetResponseStream();
                StreamReader streamReader = new StreamReader(stream);
                string json = streamReader.ReadToEnd();

                List<Model.Cliente> listaCliente = new List<Model.Cliente>();
                listaCliente = JsonConvert.DeserializeObject<List<Model.Cliente>>(json);
                //Model.Cliente clienteUnico = JsonConvert.DeserializeObject<Model.Cliente>(json);

                listaCliente = listaCliente.OrderBy(cliente => cliente.cont_nome_fantasia).ToList();

                BuscarNoGoogle(listaCliente[0].cont_nome_fantasia);
            }
        }

        public static void BuscarNoGoogle(string query)
        {
            CustomsearchService customsearchService = new CustomsearchService(new BaseClientService.Initializer
            {
                ApplicationName = "GoogleAPI",
                ApiKey = "key da api"
            });

            var searchRequest = customsearchService.Cse.List();


            searchRequest.Cx = "a08a16e5fd98c490c";
            searchRequest.Q = query;

            var searchResponse = searchRequest.ExecuteAsync();
            var resultado = (searchResponse.Result).Items;

            var testejson = JsonConvert.SerializeObject(resultado);
            List<ResultadoGoogle> lista = JsonConvert.DeserializeObject<List<ResultadoGoogle>>(testejson);

            Console.WriteLine(query);
            foreach (ResultadoGoogle r in lista)
                Console.WriteLine(r.link);
        }
    }
}
