using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Repository
{
    public class DemoRepository : IDemoRepository
    {
        private List<DemoModel> localDemos = new List<DemoModel>();
        private Random randomGenerator = new Random();

        public void AddDemo(string demoName)
        {
            localDemos.Add(new DemoModel() { DemoName = demoName, Id = randomGenerator.Next(1, 6000000), RecordedTime = DateTime.UtcNow });
        }

        public DemoModel[] GetAllDemos()
        {
            return localDemos.ToArray();
        }

        public DemoModel GetDemo(int demoId)
        {
            var demo = localDemos.FirstOrDefault(d => d.Id == demoId);
            if (demo == null)
                throw new KeyNotFoundException("Demo does not exist");

            return demo;
        }
    }
}
