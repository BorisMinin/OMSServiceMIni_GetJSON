using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OMSServiceMini.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JsonController : ControllerBase
    {
        [HttpGet]
        [Route("info")]
        public string GetJson()
        {
            string path = @"E:\\MyWork\\GitHubMy\\OMSServiceMIni_GetJSON\\OMSServiceMini\\FolderForJSON\\";

            using (FileStream fstream = System.IO.File.OpenRead($"{path}\\author.json")) // test_json.json
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);

                return textFromFile;
            }
        }
    }
}

#region RegionForTrash, если всё ок, это будет удалено
        //using (StreamReader r = new StreamReader("C:\\test.json"))
        //{
        //    string json = r.ReadToEnd();
        //    Test item = JsonConvert.DeserializeObject<Test>(json);
        //}
            //////////////////////////////////1//////////////////////////////////
            //using (StreamReader r = new StreamReader(
            //    "E:\\MyWork\\GitHubMy\\OMSServiceMIni_GetJSON\\OMSServiceMini\\FolderForJSON\\test_json.json"))//"C:\\test.json"))
            //{
            //    string json = r.ReadToEnd();
            //    Test item = JsonConvert.DeserializeObject<Test>(json);
            //    return item.ToString();
            //}

            //////////////////////////////////2//////////////////////////////////
            //var jsonString =
            //    System.IO.File.ReadAllText(
            //        "E:\\MyWork\\GitHubMy\\OMSServiceMIni_GetJSON\\OMSServiceMini\\FolderForJSON\\test_json.json");//("C:\\test_json.json");
            //Test items = JsonConvert.DeserializeObject<Test>(jsonString);
            ////return await item;
            //return items.ToString();

    //public class Test
    //{
    //    public string status { get; set; }
    //    public int code { get; set; }
    //    public string message { get; set; }
    //}
#endregion