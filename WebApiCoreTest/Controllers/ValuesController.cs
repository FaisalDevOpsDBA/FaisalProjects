using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using WebApiCoreTest.Model;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;

namespace WebApiCoreTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IConfiguration Configuration;
        

        public ValuesController(IConfiguration configuration)
        {
            Configuration = configuration;


        }
        // GET api/valuessss
        //[Authorize]
        [HttpGet]
        //[EnableCors(origins :"*")]
        public ActionResult<List<FruitModel>> Get()
        {
            string jsonPath = Configuration.GetSection("JSONPath").Value;
            
            List<FruitModel> lstfruitModel = JsonConvert.DeserializeObject<List<FruitModel>>(System.IO.File.ReadAllText(jsonPath));


            return lstfruitModel;
        }

        // GET api/values/5
        [HttpGet("{id}/{id2}")]
        public ActionResult<FruitModel> Get(int id,int id2)
        {
            string jsonPath = Configuration.GetSection("JSONPath").Value;

            FruitModel fruitModel = JsonConvert.DeserializeObject<List<FruitModel>>(System.IO.File.ReadAllText(jsonPath)).Find(f => f.Id == id);


            return fruitModel;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] FruitModel fruitModel)
        {
            string jsonPath = Configuration.GetSection("JSONPath").Value;

            var list = JsonConvert.DeserializeObject<List<FruitModel>>(System.IO.File.ReadAllText(jsonPath));
            list.Add(fruitModel);
            var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);
            System.IO.File.WriteAllText(jsonPath, convertedJson);
        }

        //[HttpPost]
        //public void Post2([FromBody] FruitModel fruitModel)
        //{
        //    string jsonPath = Configuration.GetSection("JSONPath").Value;

        //    var list = JsonConvert.DeserializeObject<List<FruitModel>>(System.IO.File.ReadAllText(jsonPath));
        //    list.Add(fruitModel);
        //    var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);
        //    System.IO.File.WriteAllText(jsonPath, convertedJson);
        //}

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] FruitModel fruitModel)
        {
            string jsonPath = Configuration.GetSection("JSONPath").Value;
            

            var list = JsonConvert.DeserializeObject<List<FruitModel>>(System.IO.File.ReadAllText(jsonPath));
            var fruitToUpdate = list.Find(f => f.Id == id);
            fruitToUpdate.Color = fruitModel.Color;
            fruitToUpdate.Fruit = fruitModel.Fruit;
            fruitToUpdate.Size = fruitModel.Size;
            var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);
            System.IO.File.WriteAllText(jsonPath, convertedJson);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            string jsonPath = Configuration.GetSection("JSONPath").Value;
            var list = JsonConvert.DeserializeObject<List<FruitModel>>(System.IO.File.ReadAllText(jsonPath));
            var fruitToDelete = list.Find(f => f.Id == id);
            list.Remove(fruitToDelete);
            var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);
            System.IO.File.WriteAllText(jsonPath, convertedJson);
        }
    }
}
