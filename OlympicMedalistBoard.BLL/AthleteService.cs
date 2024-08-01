﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlympicMedalistBoard.DAL;
using OlympicMedalistBoard.Models;

namespace OlympicMedalistBoard.BLL
{
    public class AthleteService
    {
        private readonly AthleteDAL _athleteDAL;
        public AthleteService(AthleteDAL athleteDAL)
        {
            _athleteDAL = athleteDAL;
        }

        public List<Athlete> GetAthletes()
        {
            return _athleteDAL.GetAthletes();
        }

        public void AddAthlete(Athlete athlete)
        {
            _athleteDAL.AddAthlete(athlete);
        }

        public void UpdateAthlete(Athlete athlete)
        {
            _athleteDAL.UpdateAthlete(athlete);
        }

        public void DeleteAthlete(Athlete athlete)
        {
            _athleteDAL.DeleteAthlete(athlete);
        }

        public void DeleteAthleteById(int id)
        {
            _athleteDAL.DeleteAthleteById(id);
        }

        public Athlete GetAthleteById(int id)
        {
            return _athleteDAL.GetAthleteById(id);
        }

        public List<Athlete> GetAthletesByCountryId(int id)
        {
            return _athleteDAL.GetAthletesByCountryId(id);
        }

        public List<Athlete> GetAthletesBySportId(int id)
        {
            return _athleteDAL.GetAthletesBySportId(id);
        }
    }
}
