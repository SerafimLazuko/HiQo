using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OAuth2.Configuration;
using OAuth2.Client.Impl;
using OAuth2.Infrastructure;

namespace MVC.Controllers.OAuthControllers
{
    public class GitHubAuthentificationController : Controller
    {
        private readonly GitHubClient _gitHubClient;

        public GitHubAuthentificationController()
        {
            _gitHubClient = new GitHubClient(new RequestFactory(), new ClientConfiguration());
        }
        

    }
}