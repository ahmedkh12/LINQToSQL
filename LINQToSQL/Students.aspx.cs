using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQToSQL
{
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //studentDataContext std = new studentDataContext("Data Source=DESKTOP-UOL3JHC;Initial Catalog=students;User Id = sa;Password=End@game2020;Encrypt=False");
            //var res = from students in std.std_infos
            //          select students;

            //GridView1.DataSource = res;
            //GridView1.DataBind();
        }

        protected void btn_insert_Click(object sender, EventArgs e)
        {
            studentDataContext std = new studentDataContext("Data Source=DESKTOP-UOL3JHC;Initial Catalog=students;User Id = sa;Password=End@game2020;Encrypt=False");
            std.insertstudent(std_name.Text, std_gander.Text, int.Parse(std_totalmarks.Text), int.Parse(text_class.Text));
            Response.Write("Record Inserted");
            //will add record using stored procedure
            std.SubmitChanges();
            
            GridView1.DataBind();
            std_name.Text = " ";
            std_gander.Text = " ";
            std_totalmarks.Text = " ";
            text_class.Text = " ";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            studentDataContext std = new studentDataContext("Data Source=DESKTOP-UOL3JHC;Initial Catalog=students;User Id = sa;Password=End@game2020;Encrypt=False");
            var res = from student in std.std_infos
                      where student.id == int.Parse(std_id.Text)
                      select student;

            foreach( var student in res)
            {
                std_name.Text = student.name.Replace(" ","");
                std_gander.Text = student.gander.Replace(" ", ""); ;
                std_totalmarks.Text = student.totalMarks.ToString().Replace(" ", ""); ;
                text_class.Text=student.@class.ToString().Replace(" ", ""); ;

            }

            GridView1.DataSource = res;
            GridView1.DataBind();
        

        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            studentDataContext std = new studentDataContext("Data Source=DESKTOP-UOL3JHC;Initial Catalog=students;User Id = sa;Password=End@game2020;Encrypt=False");
            std.updatestudent(int.Parse(std_id.Text), std_name.Text, std_gander.Text, int.Parse(std_totalmarks.Text), int.Parse(text_class.Text));
            std_name.Text = " ";
            std_gander.Text = " ";
            std_totalmarks.Text = " ";
            text_class.Text = " ";
            Response.Write("Record Updated");

        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            studentDataContext std = new studentDataContext("Data Source=DESKTOP-UOL3JHC;Initial Catalog=students;User Id = sa;Password=End@game2020;Encrypt=False");
            std.deletestudent(int.Parse(std_id.Text));
            std_name.Text = " ";
            std_gander.Text = " ";
            std_totalmarks.Text = " ";
            text_class.Text = " ";
            Response.Write("record deleted");
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentDataContext std = new studentDataContext("Data Source=DESKTOP-UOL3JHC;Initial Catalog=students;User Id = sa;Password=End@game2020;Encrypt=False");

            switch (RadioButtonList1.SelectedValue) 
            {

                case "male":
                    var res = from stud in std.std_infos
                              where stud.gander=="male"
                              select stud;
                    GridView1.DataSource = res;
                    GridView1.DataBind();
                    break;

                case "female":
                    var res2 = from stud in std.std_infos
                              where stud.gander == "female"
                              select stud;
                    GridView1.DataSource = res2;
                    GridView1.DataBind();
                    break;

            }
        }
    }
}