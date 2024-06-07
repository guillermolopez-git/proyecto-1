using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Arbol_Avl;

namespace WindowsFormsApp1.ArbolAvl
{
    class Team_Registration : Comparador
    {
        public string Team_Name { get; set; } //nombre delequipo
        public int Matches_played { get; set; } //partidos jugados
        public int Matches_won { get; set; } //partidos ganados 
        public int Goals_scored { get; set; } // Goles anotados
        public string City { get; set; } // Ciudad
        public int Goals_difference { get; set; } // diferencia de goles
        public int Goals_against { get; set; } // goles encontra
        public int Lost_Matches { get; set; } //partidos perdidos 
        public int Tied_matches { get; set; } //partidos empatados
        public int Total_goal_count { get; set; } // total de goles


        public Team_Registration(string team_name, int matches_played, int matches_won, int goals_scored, string city, int goals_difrence
            , int goals_against, int lost_maches, int tied_maches, int total_goal_count)
        {
            Team_Name = team_name;
            Matches_played = matches_played;
            Matches_won = matches_won;
            Goals_scored = goals_scored;
            City = city;
            Goals_difference = goals_difrence;
            Goals_against = goals_against;
            Lost_Matches = lost_maches;
            Tied_matches = tied_maches;
            Total_goal_count = total_goal_count;

        }

        bool Comparador.igualQue(Object op2)
        {
            Team_Registration p2 = (Team_Registration)op2;
            return Team_Name == p2.Team_Name;
        }

        bool Comparador.menorQue(Object op2)
        {
            Team_Registration p2 = (Team_Registration)op2;
            if (Team_Name.CompareTo(p2.Team_Name) < 0)
                return true;
            else
                return false;

        }

        bool Comparador.menorIgualQue(Object op2)
        {
            Team_Registration p2 = (Team_Registration)op2;
            return string.Compare(Team_Name, p2.Team_Name) <= 0;
        }

        bool Comparador.mayorQue(Object op2)
        {
            Team_Registration p2 = (Team_Registration)op2;
            return string.Compare(Team_Name, p2.Team_Name) > 0;
        }

        bool Comparador.mayorIgualQue(Object op2)
        {
            Team_Registration p2 = (Team_Registration)op2;
            return string.Compare(Team_Name, p2.Team_Name) >= 0;
        }


        public override string ToString()
        {
            return "(" + Team_Name + " - " + Matches_played + " - " + Matches_won +
                " - " + Goals_scored + " - " + City + " - " + Goals_difference +
                " - " + Goals_against + " - " + Lost_Matches + " - " + Tied_matches +
                " - " + Total_goal_count + ")";
        }
    }
}
