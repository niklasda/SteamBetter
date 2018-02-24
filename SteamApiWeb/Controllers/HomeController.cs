﻿using System.Web.Mvc;
using SteamApiClient.Interfaces;
using SteamApiClient.Services;

namespace SteamBetterWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string key = System.IO.File.ReadAllText(HttpContext.Server.MapPath("~/key.user"));

            ISteampoweredApi steam = new SteampoweredApi(key);
            var listing = steam.Dota2MatchApi.GetLeagueListing();
            var games = steam.Dota2MatchApi.GetLiveLeagueGames();

            return View();
        }

        public ActionResult About()
        {

            string key = System.IO.File.ReadAllText(HttpContext.Server.MapPath("~/key.user"));
            ISteampoweredApi steam = new SteampoweredApi(key);
            var listing = steam.Dota2MatchApi.GetLeagueListing();
            //var games = steam.Dota2MatchApi.GetLiveLeagueGames();

            return View(listing);
        }

        public ActionResult Contact()
        {
            string key = System.IO.File.ReadAllText(HttpContext.Server.MapPath("~/key.user"));
            ISteampoweredApi steam = new SteampoweredApi(key);
            //var listing = steam.Dota2MatchApi.GetLeagueListing();
            var games = steam.Dota2MatchApi.GetLiveLeagueGames();

            return View(games);
        }
    }
}