using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// reference the model binding library
using System.Web.ModelBinding;

namespace Week9
{
    public partial class student_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // connect
            var conn = new ContosoEntities();

            // use the Student class to create a new Student object
            Student s = new Student();

            // fill the properties of the new student object
            s.LastName = txtLastName.Text;
            s.FirstMidName = txtFirstMidName.Text;
            s.EnrollmentDate = Convert.ToDateTime(txtEnrollmentDate.Text);

            // save the new object to the database
            conn.Students.Add(s);
            conn.SaveChanges();

            // redirect to the students page
            Response.Redirect("students.aspx");
        }
    }
}