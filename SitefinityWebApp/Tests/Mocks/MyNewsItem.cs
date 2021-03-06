﻿// SitefinityWebApp\Tests\Mocks\MyNewsManager.cs

using Telerik.Sitefinity.Model;
using Telerik.Sitefinity.News.Model;

namespace SitefinityWebApp.Tests.Mocks
{
    public class MyNewsItem : NewsItem
    {
        public override Lstring Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        private string title;
    }
}