using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using BOL;
using DAL;

namespace test.Controllers;

[ApiController]
[Route("[controller]")]
public class testController : ControllerBase
{
        private readonly ILogger<testController> _logger;

    public testController(ILogger<testController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Student> Get()
    {   
        List<Student> list=new List<Student>();
        ISTManager mgr=new STManager();
        list =mgr.GetAll();
        return list;
    }
    [HttpPost]
    public void Add(Student student){
        ISTManager mgr=new STManager();
        mgr.insert(student);
    }


    [HttpDelete]
    [Route ("{id:}")]
    public void Delete(int id){
        ISTManager mgr=new STManager();
        mgr.delete(id);
    }
}
