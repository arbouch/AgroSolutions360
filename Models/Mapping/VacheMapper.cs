using AgroSolutions360.Models.Dtos.Vache;
using AgroSolutions360.Models.Models;

namespace AgroSolutions360.Models.Mapping
{
    public class VacheMapper
    {
        public static List<VacheDto> VachesListeMapper(List<Vache> vaches)
        {
            if (vaches == null)
            {
                return null;
            }

            return vaches.Select(vache => new VacheDto
            {
                id = vache.id,
                Numero_animal = vache.Numero_animal,
                Date_de_naissance = vache.Date_de_naissance,
                Num_mere = vache.Num_mere,
                Num_pere = vache.Num_pere,
                Race = vache.Race,
                Race_mere = vache.Race_mere,
                Race_pere = vache.Race_pere,
                Nom_animal = vache.Nom_animal,
                Sexe_animal = vache.Sexe_animal
            }).ToList();
        }


        public static VacheDto VacheByIdeMapper(Vache vache)
        {
            if (vache == null)
            {
                return null;
            }

            return new VacheDto
            {
                id = vache.id,
                Numero_animal = vache.Numero_animal,
                Date_de_naissance = vache.Date_de_naissance,
                Num_mere = vache.Num_mere,
                Num_pere = vache.Num_pere,
                Race = vache.Race,
                Race_mere = vache.Race_mere,
                Race_pere = vache.Race_pere,
                Nom_animal = vache.Nom_animal,
                Sexe_animal = vache.Sexe_animal
            };
        }

 
        public static Vache NewVacheToModel(NewVacheDto NewVache)
        {
            if (NewVache == null)
            {
                return null;
            }

            return new Vache
            {
                 Numero_animal = NewVache.Numero_animal,
                Date_de_naissance = NewVache.Date_de_naissance,
                Num_mere = NewVache.Num_mere,
                Num_pere = NewVache.Num_pere,
                Race = NewVache.Race,
                Race_mere = NewVache.Race_mere,
                Race_pere = NewVache.Race_pere,
                Nom_animal = NewVache.Nom_animal,
                Sexe_animal = NewVache.Sexe_animal
            };
        }


        public static Vache UpdateVacheToModel(UpdateVacheDto UpdateVache)
        {
            if (UpdateVache == null)
            {
                return null;
            }

            return new Vache
            {
                id = UpdateVache.id,
                Numero_animal = UpdateVache.Numero_animal,
                Date_de_naissance = UpdateVache.Date_de_naissance,
                Num_mere = UpdateVache.Num_mere,
                Num_pere = UpdateVache.Num_pere,
                Race = UpdateVache.Race,
                Race_mere = UpdateVache.Race_mere,
                Race_pere = UpdateVache.Race_pere,
                Nom_animal = UpdateVache.Nom_animal,
                Sexe_animal = UpdateVache.Sexe_animal
            };
        }


    }


}
