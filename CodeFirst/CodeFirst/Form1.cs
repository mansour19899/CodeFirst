using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst
{
    public partial class Form1 : Form
    {
        public class Course
        {
            public int Id { get; set; }
            public string Tittle { get; set; }
            public string Description { get; set; }
            public CourseLevel Level { get; set; }
            public float FullPrice { get; set; }
            public  Author Author { get; set; }
            public IList<Tagg> Taggs { get; set; }
            }
        public class Author
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public IList<Course> Courses { get; set; }
        }
        public class Tagg
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public IList<Course>  Courses { get; set; }
        }

        public enum CourseLevel
        {
            Beginner=1,
            Intermediate=2,
            Advanced=3
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
