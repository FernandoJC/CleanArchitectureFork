using CleanArchitectureSolutionTemplate.Application.Common.Interfaces;
using System;

namespace CleanArchitectureSolutionTemplate.WebUI.IntegrationTests
{
    public class TestDateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
