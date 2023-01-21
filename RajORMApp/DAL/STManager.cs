namespace DAL;
using BOL;
public class STManager:ISTManager
{    public List<Student> GetAll()
{  using(var context=new Collectioncontext())
{
var student=from std in context.allstudents select std;
return student.ToList<Student>();
}

}


public void insert(Student std)
{
using (var context = new Collectioncontext())
        {
            context.allstudents.Add(std);
            context.SaveChanges();  
        }
}

public void delete(int id)
{using(var context = new Collectioncontext())
        {
            context.allstudents.Remove(context.allstudents.Find(id));
            context.SaveChanges();
        }

}







}