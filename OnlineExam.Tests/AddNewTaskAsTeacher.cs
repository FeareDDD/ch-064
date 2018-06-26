﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Pages.POM;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
using System.Threading;

namespace OnlineExam.Tests
{
    public class AddNewTaskAsTeacher : BaseTest//, IDisposable
    {
        public AddNewTaskAsTeacher()
        {
        }

        [Fact]
        public void AddNewTaskTest()
        {
            var header = new Header(driver);
            var logInPage = header.GoToLogInPage();
            logInPage.SignIn(Constants.TEACHER_EMAIL, Constants.TEACHER_PASSWORD);

            var TeacherTasksPage = new SideBar(driver).TasksMenuItemClick();
            var Tasks = new TeacherExerciseManagerPage(driver);
            Tasks.ClickOnAddTaskbutton();
            var AddTaskPage = new AddTaskAsTeacherPage(driver);
            AddTaskPage.AddTaskNameForNewTask("Proba2");
            AddTaskPage.ClickOnAddButton();
           // Assert.Contains(Tasks.IsTaskAvailable("Proba2"),);
            
        }


        public void Dispose()
        {
            driver.Dispose();
        }

    }
}