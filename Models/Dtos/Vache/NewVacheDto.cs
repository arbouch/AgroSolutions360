﻿namespace AgroSolutions360.Models.Dtos.Vache
{
    public class NewVacheDto
    {
         public string Numero_animal { get; set; }
        public DateTime Date_de_naissance { get; set; }
        public string Num_mere { get; set; }
        public string Num_pere { get; set; }
        public string Race { get; set; }
        public string Race_mere { get; set; }
        public string Race_pere { get; set; }
        public string Nom_animal { get; set; }
        public string Sexe_animal { get; set; }
        public int IdFerme { get; set; }    
    }
}
