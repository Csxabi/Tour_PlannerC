﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using CSTourPlanner.M;

namespace CSTourPlanner.DAL
{
    public class DBA
    {
        IDbConnection Connection;
        public DBA()
        {
            Connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgresql"].ConnectionString);
            Connection.Open();
        }

        public List<Tour> GetTours()
        {
            List<Tour> tours = Connection.Query<Tour>("SELECT * FROM public.\"Tour\" ").ToList();
            foreach(Tour tour in tours)
            {
                List<Log> logs = GetlogsofTour(tour.TourID);
                foreach (Log log in logs) tour.TourLogs.Add(log);
            }
            return tours;
        }
        public List<Log> GetlogsofTour(int TourID)
        {           
                return Connection.Query<Log>("SELECT * FROM public.\"Log\" WHERE \"TourID\"=" + TourID).ToList();           
        }

    }
}