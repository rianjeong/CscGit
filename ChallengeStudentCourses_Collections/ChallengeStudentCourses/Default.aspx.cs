using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
           */

            List<Course> Courses = new List<Course>() {
                new Course() { CourseId = 1, Name = "Math 101", Students = new List<Student>() {
                    new Student() {StudentId = 100, Name = "John Galt"},
                    new Student() {StudentId = 101, Name = "Rian Jeong" }}},
                new Course() { CourseId = 2, Name = "Business 101", Students = new List<Student>() {
                    new Student() { StudentId = 102, Name = "Sean Combs"},
                    new Student() {StudentId = 103, Name = "Sarah Conor" }}},
                new Course() {CourseId = 3, Name = "juggling 802", Students = new List<Student>() {
                    new Student() {StudentId = 104, Name = "Jimmy Dean"},
                    new Student() {StudentId = 105, Name = "Bill Davis"}}}

            };

            foreach (var course in Courses)
            {
                resultLabel.Text += string.Format("</br> Course:{0} - {1}", course.CourseId, course.Name);
                foreach (var student in course.Students)
                {
                    resultLabel.Text += string.Format("</br> &nbsp;&nbsp;Student: {0} -{1}", student.StudentId, student.Name); 
                }

            }

            
        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */
            Course course1 = new Course() { CourseId = 100, Name = "Math 101" };
            Course course2 = new Course() { CourseId = 200, Name = "Cooking 200" };
            Course course3 = new Course() { CourseId = 300, Name = "Econ 300" };

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                { 1, new Student {StudentId = 1, Name = "Sean Combs", Courses = new List<Course> {course1, course2 } } },
                { 2, new Student {StudentId = 2, Name = "Rian Jeong", Courses = new List<Course> {course2, course3 } } },
                { 3, new Student {StudentId = 3, Name = "Dick Hardgood", Courses = new List<Course> {course1, course3 } } }
            };
            foreach (var student in students)
            {
                resultLabel.Text += String.Format("</br> Student: {0} - {1}", student.Value.StudentId, student.Value.Name);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("</br>&nbsp; &nbsp Course: {0} - {1}", course.CourseId, course.Name); 
                }
            }

        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */

            Student student = new Student();
            student.StudentId = 10; 
            student.Name = "Rian Jeong"; 
            student.Enrollments = new List<Enrollment>(){
                new Enrollment {Grade = 92, Course = new Course { CourseId = 1, Name = "Psychology 101"} },
                new Enrollment {Grade = 95, Course = new Course { CourseId = 2, Name = "Math 200" } },
            };

            resultLabel.Text += String.Format("</br>Student: {0} - {1}", student.StudentId, student.Name);
            foreach (var enrollment in student.Enrollments)
            {
                resultLabel.Text += String.Format("</br>Enrolled in: {0} - Grade: {1}", enrollment.Course.Name, enrollment.Grade); 
            }
        }
    }
}