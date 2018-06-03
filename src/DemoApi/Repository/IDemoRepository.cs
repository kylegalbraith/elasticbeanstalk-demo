using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Repository
{
    public interface IDemoRepository
    {
        DemoModel[] GetAllDemos();
        DemoModel GetDemo(int demoId);
        void AddDemo(string demoName);
    }

    public class DemoModel
    {
        public int Id { get; set; }
        public DateTime RecordedTime { get; set; }
        public string DemoName { get; set; }
    }
   
}
