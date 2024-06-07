using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.ListaEnlazada
{
    class DataJugadores
    {
            public string FullName { get; set; } // nombre completo
            public int Age { get; set; } // edad
            public string Season { get; set; } // temporada
            public string Position { get; set; } // posición
            public string CurrentClub { get; set; } // club actual
            public int MinutesPlayedOverall { get; set; } // minutos jugados en total
            public string Nationality { get; set; } // nacionalidad
            public int GoalsOverall { get; set; } // goles en total
            public int AssistsOverall { get; set; } // asistencias en total
            public int PenaltyGoals { get; set; } // goles de penalti
            public int YellowCardsOverall { get; set; } // tarjetas amarillas en total
            public int RedCardsOverall { get; set; } // tarjetas rojas en total
            public int Camisolenumber { get; set; } // numero camisola

        public DataJugadores(string fullName, int age, string season, string position, string currentClub,
                       int minutesPlayedOverall, string nationality, int goalsOverall,
                       int assistsOverall, int penaltyGoals, int yellowCardsOverall, int redCardsOverall,int camisolenumber)
        {
            FullName = fullName; 
            Age = age; 
            Season = season;
            Position = position;
            CurrentClub = currentClub;
            MinutesPlayedOverall = minutesPlayedOverall; 
            Nationality = nationality; 
            GoalsOverall = goalsOverall; 
            AssistsOverall = assistsOverall;
            PenaltyGoals = penaltyGoals; 
            YellowCardsOverall = yellowCardsOverall; 
            RedCardsOverall = redCardsOverall;
            Camisolenumber=camisolenumber;


        }
    }
}
