﻿using CleanArchitectureSolutionTemplate.Application.Common.Interfaces;

namespace CleanArchitectureSolutionTemplate.WebUI.IntegrationTests
{
    public class TestCurrentUserService : ICurrentUserService
    {
        public string UserId => "00000000-0000-0000-0000-000000000000";
    }
}
