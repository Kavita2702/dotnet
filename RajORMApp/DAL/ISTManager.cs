namespace DAL;
using BOL;
public interface ISTManager
{
    List<Student>GetAll();
    void insert(Student std);
    
    void delete(int id);
    
}
