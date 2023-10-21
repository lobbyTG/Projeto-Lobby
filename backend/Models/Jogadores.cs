
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeAPI.Models
{
public class Jogadores
    {
        [Key]
        public int JogadoresId { get; set; }
        public int Jogador1 { get; set; }
   //     public bool confirmado1 { get; set; }

        public int Jogador2 { get; set; }
        
  //      public bool confirmado2 { get; set; }

        public int Jogador3 { get; set; }

//        public bool confirmado3 { get; set; }
        public int Jogador4 { get; set; }

 //       public bool confirmado5 { get; set; }
        public int Jogador5 { get; set; }
        

    }
}