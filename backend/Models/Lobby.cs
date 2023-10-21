using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LobbyAPI.Models
{
    public class Lobby
    {
        [Key]
        public int LobbyId { get; set; }

        [Column(TypeName ="nvarchar(20)")]
        public string Hora { get; set; }
        public int IdQuadra { get; set; }


        [ForeignKey("Jogadores")]
        public int JogadoresId { get; set; }

    }

    public class Jogador
    {
        [Key]
        public int JogadoresId { get; set; }
        public int Jogador1 { get; set; }

        public int Jogador2 { get; set; }
        
        public int Jogador3 { get; set; }

        public int Jogador4 { get; set; }

        public int Jogador5 { get; set; }
        
     

    }
}

