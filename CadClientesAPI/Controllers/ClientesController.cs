using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using ConsultaAPI.Models;

namespace ConsultaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ClientesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get() 
        {
            string sql = @" select * from clientes";

            DataTable dt = new DataTable();
            string dtSource = _configuration.GetConnectionString("APIConn");
            MySqlDataReader reader;
            using (MySqlConnection cn = new MySqlConnection(dtSource))
            {
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, cn)) 
                {
                    reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    reader.Close();
                }
                cn.Close();

                return new JsonResult(dt);
            }
            
        }

        //GET - CONSULTA CLIENTE POR ID
        [HttpGet("{id:int}")]
        public JsonResult Get(int id)
        {
            string sql = @" select * from clientes where id = @id";

            DataTable dt = new DataTable();
            string dtSource = _configuration.GetConnectionString("APIConn");
            MySqlDataReader reader;
            using (MySqlConnection cn = new MySqlConnection(dtSource))
            {
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Prepare();
                    reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    reader.Close();
                }
                cn.Close();

                return new JsonResult(dt);
            }

        }
        //GET - ULTIMO CODIGO INSERIDO
        [HttpGet("Ultimo")]
        public JsonResult GetUltimo()
        {
            string sql = @" select max(id) as id, nome, dt_nasc, cep, cidade, estado, logradouro  from clientes";

            DataTable dt = new DataTable();
            string dtSource = _configuration.GetConnectionString("APIConn");
            MySqlDataReader reader;
            using (MySqlConnection cn = new MySqlConnection(dtSource))
            {
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Prepare();
                    reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    reader.Close();
                }
                cn.Close();

                return new JsonResult(dt);
            }

        }


        // POST - INSERIR CLIENTE
        [HttpPost]
        public JsonResult Post(Clientes cli)
        {
            string sql = @" insert into clientes (id, nome, dt_nasc, cep, cidade, estado, logradouro) 
                            values (@id, @nome, @dt_nasc, @cep, @cidade, @estado, @logradouro)
                                
            ";

            DataTable dt = new DataTable();
            string dtSource = _configuration.GetConnectionString("APIConn");
            MySqlDataReader reader;
            using (MySqlConnection cn = new MySqlConnection(dtSource))
            {
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", cli.id);
                    cmd.Parameters.AddWithValue("@nome", cli.nome);
                    cmd.Parameters.AddWithValue("@dt_nasc", cli.dt_nasc);
                    cmd.Parameters.AddWithValue("@cep", cli.cep);
                    cmd.Parameters.AddWithValue("@cidade", cli.cidade);
                    cmd.Parameters.AddWithValue("@estado", cli.estado);
                    cmd.Parameters.AddWithValue("@logradouro", cli.logradouro);
                    cmd.Prepare();
                    reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    reader.Close();
                }
                cn.Close();

                return new JsonResult("Sucesso");
            }

        }
    }
}
