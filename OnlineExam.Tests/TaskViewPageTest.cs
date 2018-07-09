﻿using OnlineExam.Pages.POM;
using OnlineExam.Pages.POM.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Xunit;

namespace OnlineExam.Tests
{
    public class TaskViewPageTest : BaseTest
    {
        public TaskViewPageTest() { }


        [Fact]
        public void ClickOnStartButton()
        {
            //string TaskName = "Simple addition";
            //var header = ConstructPage<Header>();
            //var logInPage = header.GoToLogInPage();
            //logInPage.SignIn(Constants.STUDENT_EMAIL, Constants.STUDENT_PASSWORD);
            //driver.Navigate().GoToUrl("http://localhost:55842/CourseManagement/ShowExercise/1");
            //var ListOfTasks = ConstructPage<TasksPage>();
            //var blocks = ListOfTasks.GetBlocks();
            //if (blocks != null)
            //{
            //    var firstblock = blocks.FirstOrDefault(x => x.GetName().Equals(TaskName, StringComparison.OrdinalIgnoreCase));
            //    firstblock.ClickOnTasksButton();
            //    var TaskView = ConstructPage<TaskViewPage>();
            //    TaskView.ClickOnStartButton();
            //    Assert.Equal(driver.Title, "- WebApp");
            //}
        }


        [Fact]
        public void ClickOnOkButton()
        {
            throw new Exception("Rewrite using Page constructor");
            //string TaskName = "Simple addition";
            //var header = ConstructPage<Header>();
            //var logInPage = header.GoToLogInPage();
            //logInPage.SignIn(Constants.STUDENT_EMAIL, Constants.STUDENT_PASSWORD);
            //driver.Navigate().GoToUrl("http://localhost:55842/CourseManagement/ShowExercise/1");
            //var ListOfTasks = ConstructPage<TasksPage>();
            //var blocks = ListOfTasks.GetBlocks();
            //if (blocks != null)
            //{
            //    var firstblock = blocks.FirstOrDefault(x => x.GetName().Equals(TaskName, StringComparison.OrdinalIgnoreCase));
            //    firstblock.ClickOnTasksButton();
            //    var TaskView = ConstructPage<TaskViewPage>();
            //    TaskView.ClickOnOkButton();
            //    Assert.Equal(driver.Url, "http://localhost:55842/CourseManagement/ShowExercise/1");
            //}
        }


        [Fact]
        public void EmailFromComment()
        {
            throw new Exception("Rewrite using Page constructor");
            //string TaskName = "Simple addition";
            //string email = "student@gmail.com";
            //var header = ConstructPage<Header>();
            //var logInPage = header.GoToLogInPage();
            //logInPage.SignIn(Constants.STUDENT_EMAIL, Constants.STUDENT_PASSWORD);
            //driver.Navigate().GoToUrl("http://localhost:55842/CourseManagement/ShowExercise/1");
            //var ListOfTasks = ConstructPage<TasksPage>();
            //var blocks = ListOfTasks.GetBlocks();
            //if (blocks != null)
            //{
            //    var firstblock = blocks.FirstOrDefault(x => x.GetName().Equals(TaskName, StringComparison.OrdinalIgnoreCase));
            //    firstblock.ClickOnTasksButton();
            //    var TaskView = ConstructPage<TaskViewPage>();
            //    var divs = TaskView.GetDivs();
            //    if (divs != null)
            //    {
            //        var anyblock = divs.Any(x => x.GetEmail().Equals(email, StringComparison.OrdinalIgnoreCase));
            //        Assert.True(anyblock);
            //    }
            //}
        }


        [Fact]
        public void TextFromComment()
        {
            throw new Exception("Rewrite using Page constructor");
            //string TaskName = "Simple addition";
            //string email = "student@gmail.com";
            //var header = ConstructPage<Header>();
            //var logInPage = header.GoToLogInPage();
            //logInPage.SignIn(Constants.STUDENT_EMAIL, Constants.STUDENT_PASSWORD);
            //driver.Navigate().GoToUrl("http://localhost:55842/CourseManagement/ShowExercise/1");
            //var ListOfTasks = ConstructPage<TasksPage>();
            //var blocks = ListOfTasks.GetBlocks();
            //if (blocks != null)
            //{
            //    var firstblock = blocks.FirstOrDefault(x => x.GetName().Equals(TaskName, StringComparison.OrdinalIgnoreCase));
            //    firstblock.ClickOnTasksButton();
            //    var TaskView = ConstructPage<TaskViewPage>();
            //    var divs = TaskView.GetDivs();
            //    if (divs != null)
            //    {
            //        var anyblock = divs.FirstOrDefault(x => x.GetEmail().Equals(email, StringComparison.OrdinalIgnoreCase));
            //        var comment = anyblock.GetCommentText();
            //        Assert.Equal(comment.ToString(), "e-yo!");
            //    }
            //}
        }

        [Fact]
        public void DateFromComment()
        {
            throw new Exception("Rewrite using Page constructor");
            //string TaskName = "Simple addition";
            //string coment = "one more comment";
            
            //var header = ConstructPage<Header>();
            //var logInPage = header.GoToLogInPage();
            //logInPage.SignIn(Constants.STUDENT_EMAIL, Constants.STUDENT_PASSWORD);
            //driver.Navigate().GoToUrl("http://localhost:55842/CourseManagement/ShowExercise/1");
            //var ListOfTasks = ConstructPage<TasksPage>();
            //var blocks = ListOfTasks.GetBlocks();
            //if (blocks != null)
            //{
            //    var firstblock = blocks.FirstOrDefault(x => x.GetName().Equals(TaskName, StringComparison.OrdinalIgnoreCase));
            //    firstblock.ClickOnTasksButton();
            //    var TaskView = ConstructPage<TaskViewPage>();
            //    var divs = TaskView.GetDivs();
            //    if (divs != null)
            //    {
            //        var anyblock = divs.FirstOrDefault(x => x.GetCommentText().Equals(coment, StringComparison.OrdinalIgnoreCase));
            //        var date = anyblock.GetCommentDate();
            //        Assert.Equal(date.ToString(), "6/25/2018 8:08:04 PM");
            //    }
            //}
        }



    }
}

    