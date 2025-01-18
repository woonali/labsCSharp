using lab8.Models;
using lab8.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8.Presenters
{
    internal class StudentPresenter
    {
        private readonly IStusentView view;
        private readonly StudentModel model;

        public StudentPresenter(IStusentView view, StudentModel model)
        {
            this.view = view;
            this.model = model;

            view.fillTable += onFillTable;
            view.addStudent += onAddStudent;
            view.updateStudent += onUpdateStudent;
            view.deleteStudent += onDeleteStudent;
        }

        private void onFillTable(object sender, EventArgs e)
        {
            view.fillTableOfStudents(model.readStudents());
        }

        private void onAddStudent(object sender, EventArgs e)
        {
            model.createStudent(view.recordBook, view.nameStudent, view.department, view.specification, view.dateOfAdmission, view.group);
            onFillTable(sender, e);
        }

        private void onUpdateStudent(object sender, EventArgs e)
        {
            model.updateStudent(view.oldRecordBook, view.recordBook, view.nameStudent, view.department,
                view.specification, view.dateOfAdmission,view.group);
            onFillTable(sender, e);
        }

        private void onDeleteStudent(object sender, EventArgs e)
        {
            model.deleteStudent(view.recordBook);
            onFillTable(sender, e);
        }
    }
}
