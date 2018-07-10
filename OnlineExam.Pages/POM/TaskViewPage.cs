﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Pages.POM.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

//MISHA

namespace OnlineExam.Pages.POM
{
    public class TaskViewPage : BasePage
    {
        public TaskViewPage() { }

        public IList<TaskViewPageDivItem> GetDivs()
        {
            var blocks = new List<TaskViewPageDivItem>();
            foreach (var div in RowOfDiv)
            {
                var block = ConstructPageElement<TaskViewPageDivItem>(div);
                if (block != null)
                    blocks.Add(block);
            }
            return blocks;
        }

        [FindsBy(How = How.CssSelector, Using = ".panel.panel-info")]
        public IList<IWebElement> RowOfDiv { get; set; }

        public IList<TaskViewPageDivItem> DivItems { get; set; }

        public TaskViewPageDivItem GetByEmail(string Email)
        {
            return DivItems.FirstOrDefault(x => String.Equals(x.GetEmail(), Email, StringComparison.OrdinalIgnoreCase));
        }

        public TaskViewPageDivItem GetByCommentText(string Email)
        {
            return DivItems.FirstOrDefault(x => String.Equals(x.GetCommentText(), Email, StringComparison.OrdinalIgnoreCase));
        }

        public TaskViewPageDivItem GetByCommentDate(string Email)
        {
            return DivItems.FirstOrDefault(x => String.Equals(x.GetCommentDate(), Email, StringComparison.OrdinalIgnoreCase));
        }

        public TaskViewPageDivItem GetStarsCount(int countstars)
        {
            return DivItems.FirstOrDefault(x => String.Equals(x.GetStarsss(), countstars.ToString(), StringComparison.OrdinalIgnoreCase));
        }


        [FindsBy(How =How.Id, Using = "textField")]
        public IWebElement commenttext { get; set; }

        [FindsBy(How = How.ClassName, Using = "form-control")]
        public IWebElement TaskName { get; set; }

        [FindsBy(How = How.ClassName, Using = "mce-content-body")]
        public IWebElement TaskDiscription { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/form/div[5]/div[6]/div[1]/div/div/div/div[5]/div[1]/pre/span")]
        public IWebElement TaskCode { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div > div > form > div.col-md-1 > input")]
        public IWebElement OkButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div > div > div.col-md-2 > form > button")]
        public IWebElement StartButton { get; set; }

        [FindsBy(How = How.Id, Using = "tggl")]
        public IWebElement ShowHideCommentsButton { get; set; }

        [FindsBy(How = How.Id, Using = "buttn")]
        public IWebElement CommentButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#rateField > span > span")]
        public IWebElement StarsComment_4 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#rateField > span")]
        public IWebElement StarsComment_3 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#rateField > span > span > span > span")]
        public IWebElement StarsComment_5 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#rateField > span > span.::before")]
        public IWebElement StarsComment_ { get; set; }

        public void Click__Star()
        {
            StarsComment_.Click();
        }

        public void Click_4_Star()
        {
            StarsComment_4.Click();
        }

        public void Click_3_Star()
        {
            StarsComment_3.Click();
        }

        public void Click_5_Star()
        {
            StarsComment_5.Click();
        }

        public void ClickOnCommentButton()
        {
            CommentButton.Click();
        }

        public void CreateCommentText(string text)
        {
            commenttext.SendKeys(text);
        }

        public void FillCode(string code)
        {
            TaskCode.Clear();
            TaskCode.SendKeys(code);
        }

        public void ClickOnOkButton()
        {
            OkButton.Click();
        }

        public void ClickOnStartButton()
        {
            StartButton.Click();
        }

        public void ClickOnShowHideCommentsButton()
        {
            ShowHideCommentsButton.Click();
        }

    }
}