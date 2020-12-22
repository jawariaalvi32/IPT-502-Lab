using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using Newtonsoft.Json;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for MyFirstWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class MyFirstWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        } 

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        public string percentage()
        {
            string details = HttpContext.Current.Request.Params["request"];
            List<subject> subjects = JsonConvert.DeserializeObject<List<subject>>(details);

            int min = subjects[0].marksObtained;
            string minSub = subjects[0].subName;
            int max = subjects[0].marksObtained;
            string maxSub = subjects[0].subName;
            double totalMarks = 0.0;

            for (int i = 0; i < subjects.Count; i++)
            {
                totalMarks += subjects[i].marksObtained;
                if (min > subjects[i].marksObtained)
                {
                    min = subjects[i].marksObtained;
                    minSub = subjects[i].subName;
                }

                if (max < subjects[i].marksObtained)
                {
                    max = subjects[i].marksObtained;
                    maxSub = subjects[i].subName;
                }
            }

            double percentage = ((totalMarks / (subjects.Count * 100)) * 100);

            subject marksheet = new subject();
            marksheet.percentage = percentage;
            marksheet.minMarks = min;
            marksheet.maxMarks = max;
            marksheet.minSubjectMarks = minSub;
            marksheet.maxSubjectMarks = maxSub;

            string str = JsonConvert.SerializeObject(marksheet);
            return str;

        }
    }

    public class subject
    {
        public string subName { get; set; }
        public int marksObtained { get; set; }
        public double percentage { get; set; }
        public double minMarks { get; set; }
        public double maxMarks { get; set; }
        public string minSubjectMarks { get; set; }
        public string maxSubjectMarks { get; set; }
    }
}
