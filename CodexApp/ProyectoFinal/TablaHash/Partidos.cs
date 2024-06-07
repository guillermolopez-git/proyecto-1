using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.TablaHash
{
    class Partidos
    {
        public string DateGMT { get; set; } // Fecha y hora del partido
        public int Attendance { get; set; } // Asistencia (número de espectadores)
        public string Home_Team_Name { get; set; } // Nombre del equipo local
        public string AwayTeamName { get; set; } // Nombre del equipo visitante
        public string Referee { get; set; } // Árbitro del partido
        public int HomeTeamGoalCount { get; set; } // Cantidad de goles del equipo local
        public int AwayTeamGoalCount { get; set; } // Cantidad de goles del equipo visitante
        public double HomeTeamPossession { get; set; } // Posesión del equipo local (porcentaje)
        public double AwayTeamPossession { get; set; } // Posesión del equipo visitante (porcentaje)
        public string StadiumName { get; set; } // Nombre del estadio

        public Partidos(string dateGMT, int attendance, string homeTeamName, string awayTeamName, string referee, int homeTeamGoalCount, int awayTeamGoalCount, double homeTeamPossession, double awayTeamPossession, string stadiumName)
        {
            DateGMT = dateGMT;
            Attendance = attendance;
            Home_Team_Name = homeTeamName;
            AwayTeamName = awayTeamName;
            Referee = referee;
            HomeTeamGoalCount = homeTeamGoalCount;
            AwayTeamGoalCount = awayTeamGoalCount;
            HomeTeamPossession = homeTeamPossession;
            AwayTeamPossession = awayTeamPossession;
            StadiumName = stadiumName;
        }
    }


}
