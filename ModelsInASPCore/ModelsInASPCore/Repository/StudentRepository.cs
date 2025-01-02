using ModelsInASPCore.Models;

namespace ModelsInASPCore.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }

        public StudentModel getStudentById(int id)
        {
            return DataSource().Where(x => x.rollNo == id).FirstOrDefault();   
        }


        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {
                new StudentModel { rollNo = 1, Name = "Paras", Standard = 11, Gender = "Male"},
                new StudentModel { rollNo = 2, Name = "Ranjana", Standard = 11, Gender = "Female"},
                new StudentModel { rollNo = 3, Name = "Vijay", Standard = 10, Gender = "Male"},
                new StudentModel { rollNo = 4, Name = "Rajiv", Standard = 10, Gender = "Male"},
                new StudentModel { rollNo = 5, Name = "Sham", Standard = 10, Gender = "Male"}
            };

        }
    } 

}
