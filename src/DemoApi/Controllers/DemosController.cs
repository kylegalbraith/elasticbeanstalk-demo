using System.Collections.Generic;
using DemoApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    public class DemosController : ControllerBase
    {
        private IDemoRepository _demoRepository;

        public DemosController(IDemoRepository demoRepository)
        {
            _demoRepository = demoRepository;
        }

        // GET api/demo
        [HttpGet]
        public IEnumerable<DemoModel> Get()
        {
            return _demoRepository.GetAllDemos();
        }

        // GET api/demos/5
        [HttpGet("{id}")]
        public DemoModel Get(int id)
        {
            return _demoRepository.GetDemo(id);
        }

        // POST api/demos
        [HttpPost]
        public void Post([FromBody]NewDemoModel model)
        {
            _demoRepository.AddDemo(model.Name);
        }
    }

    public class NewDemoModel
    {
        public string Name { get; set; }
    }
}
