using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQToSQL
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
        }



        protected void Button2_Click(object sender, EventArgs e)
        {
            //insert new student 
            studentDataContext std = new studentDataContext("Data Source=DESKTOP-UOL3JHC;Initial Catalog=students;User Id = sa;Password=End@game2020;Encrypt=False");

                //std_info stdd = new std_info()

                //{
                //    name = "Mohamed",
                //    gander = "male",
                //    totalMarks = 200,
                //    @class = 1,
                //};
                //std.std_infos.InsertOnSubmit(stdd);
                //std.SubmitChanges();

                std.insertstudent("mohamed", "male", 150, 1); // insert student using stored procedure 

            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            using (studentDataContext std = new studentDataContext("Data Source=DESKTOP-UOL3JHC;Initial Catalog=students;User Id = sa;Password=End@game2020;Encrypt=False"))
            {

                std_info stdd = std.std_infos.SingleOrDefault(x => x.id == 6); //create object from class std_info
                std.std_infos.DeleteOnSubmit(stdd); // to delete selected student 
                std.SubmitChanges(); //save changes 

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {  
            //update record in sql 
            using (studentDataContext std = new studentDataContext("Data Source=DESKTOP-UOL3JHC;Initial Catalog=students;User Id = sa;Password=End@game2020;Encrypt=False"))
            {

                std_info stdd = std.std_infos.SingleOrDefault(x => x.id == 6); //create object from class std_info
                stdd.totalMarks = 300;
                std.SubmitChanges(); //save changes 

            }
        }


        protected void GetData()
        {
            studentDataContext std = new studentDataContext("Data Source=DESKTOP-UOL3JHC;Initial Catalog=students;User Id = sa;Password=End@game2020;Encrypt=False");

            var res = from student in std.std_infos
                      select student; // select all students from student table 

            GridView1.DataSource = res;
            GridView1.DataBind();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            studentDataContext std = new studentDataContext("Data Source=DESKTOP-UOL3JHC;Initial Catalog=students;User Id = sa;Password=End@game2020;Encrypt=False");
            if (TextBox1.Text == null || TextBox1.Text == " " || TextBox1.Text == "0")
            {
                GetData();
            }
            else
            {
                var inputval = TextBox1.Text;
                var res = from student in std.std_infos
                          where student.id == int.Parse(inputval)
                          select student;
                var res2 = std.SelectAllStudents();  //get data by sql stored procedure
               


                

                msg.Text=res2.ToString();    // to get the sql query 

                msg.Text = std.GetCommand(res).CommandText; // to get the sql query 

                GridView1.DataSource = res2;
                GridView1.DataBind();
            }
        }
    }
}