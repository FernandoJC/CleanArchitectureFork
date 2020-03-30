using CleanArchitectureSolutionTemplate.Application.Common.Interfaces;
using System;

namespace CleanArchitectureSolutionTemplate.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
