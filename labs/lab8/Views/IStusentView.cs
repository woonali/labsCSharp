using System;
using System.Data;

namespace lab8.Views
{
    public interface IStusentView
    {
        int recordBook {  get; set; }
        string nameStudent { get; set; }
        string department { get; set; }
        string specification { get; set; }
        DateTime dateOfAdmission { get; set; }
        string group {  get; set; }
        int oldRecordBook {  get; }

        void fillTableOfStudents(DataTable data);

        event EventHandler fillTable;
        event EventHandler addStudent;
        event EventHandler updateStudent;
        event EventHandler deleteStudent;
    }
}
