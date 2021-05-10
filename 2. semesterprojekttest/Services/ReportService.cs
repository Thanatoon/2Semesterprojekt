﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using _2._semesterprojekttest.Interfaces;
using _2._semesterprojekttest.Models;

namespace _2._semesterprojekttest.Services
{
    public class ReportService : IReportService
    {
        private GrydenDBContext db = new GrydenDBContext();
        //For at kunne bruge Entity skal du downloade Nuget packages: Microsoft.EntityFrameWorkCore.Tools og Microsoft.EntityFrameWorkCore.SqlServer
        public void AddReport(Report report)
        {
            db.Reports.Add(report);
            db.SaveChanges();
        }
    }
}