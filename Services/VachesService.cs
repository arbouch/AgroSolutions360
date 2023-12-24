using AgroSolutions360.Context;
using AgroSolutions360.Interfaces;
using AgroSolutions360.Models.Dtos.Vache;
using AgroSolutions360.Models.Mapping;
using AgroSolutions360.Models.Models;
using AgroSolutions360.Results;
using Microsoft.EntityFrameworkCore;

namespace AgroSolutions360.Services
{
    public class VachesService : IVachesService
    {
        public readonly ApplicationDbContext _applicationDbContext;
        public VachesService(ApplicationDbContext applicationDbContext) {
            _applicationDbContext = applicationDbContext;
        }

        public OperationResult<NewVacheDto> AjoutVache(NewVacheDto NewVache)
        {
            if(NewVache ==null)
            {
                return new OperationResult<NewVacheDto>
                {
                    ErrorMessage = "Données Invalides",
                    Success = false,

                };
            }
                
            var AddVache = VacheMapper.NewVacheToModel(NewVache);
            _applicationDbContext.Vaches.Add(AddVache); 
            _applicationDbContext.SaveChanges();    
            return new OperationResult<NewVacheDto>(NewVache);

         }

        public OperationResult<VacheDto> GetVacheById(int IdVache,int IdFerme)
        { 
            if(IdVache <1)
            {
                return new OperationResult<VacheDto>
                {
                    Success = false,
                    ErrorMessage = "Verifier l'ID en parametre."
                };
            }

            var vache = _applicationDbContext.Vaches.Where(i =>i.id == IdVache && i.IdFerme == IdFerme).FirstOrDefault();
            if (vache == null)
            {
                return new OperationResult<VacheDto>
                {
                    Success = false,
                    ErrorMessage = "Aucune Vache est trouvée avec l'ID en parametre."
                };
            }

            var VacheD =VacheMapper.VacheByIdeMapper(vache);
            var result = new OperationResult<VacheDto>(VacheD);
            return result; 
        }

        public OperationResult<UpdateVacheDto> ModificationVache(UpdateVacheDto UpdateVache)
        {
            if (UpdateVache==null)
            {
                return new OperationResult<UpdateVacheDto>
                {
                    Success = false,
                    ErrorMessage = "Verifier les données en parametre."
                };

            }
            var VacheToUpdate = _applicationDbContext.Vaches.AsNoTracking().Where(i=> i.id == UpdateVache.id).FirstOrDefault();
            if (VacheToUpdate==null)
            {
                return new OperationResult<UpdateVacheDto>
                {
                    Success = false,
                    ErrorMessage = "Aucune Vache est trouvée avec l'ID en parametre."
                };

            }
            var VacheUpdated = VacheMapper.UpdateVacheToModel(UpdateVache);
            _applicationDbContext.Vaches.Update(VacheUpdated);
            _applicationDbContext.SaveChanges();
            return new OperationResult<UpdateVacheDto>(UpdateVache);

        }

        public OperationResult<List<VacheDto>> RechercheVaches( int IdFerme)
        {
            try
            {
                 List<Vache> vacheList = _applicationDbContext.Vaches.Where( i=> i.IdFerme == IdFerme).ToList();

                 List<VacheDto> vacheDTOList = VacheMapper.VachesListeMapper(vacheList);

                 var result = new OperationResult<List<VacheDto>>(vacheDTOList);

                return result;
            }
            catch (Exception ex)
            {
                 return new OperationResult<List<VacheDto>>(ex.Message);
            }
        }

        public OperationResult<int> SupprimerVache(int SupprimerVacheId, int IdFerme)
        {
            if (SupprimerVacheId  < 1)
            {
                return new OperationResult<int>()
                {
                    Success = false,
                    ErrorMessage = "Verifier l'ID en parametre"
                };
            }
          var VacheAsupprimer  =_applicationDbContext.Vaches.Where(i=>i.id == SupprimerVacheId && i.IdFerme == IdFerme).FirstOrDefault();
            if(VacheAsupprimer == null) { 
            return new OperationResult<int>
            {
                Success = false,
                ErrorMessage = "Aucune Vache est trouvée avec l'ID en parametre."
            };
            }
             _applicationDbContext.Vaches.Remove(VacheAsupprimer);
            int affectedRows = _applicationDbContext.SaveChanges();
            if (affectedRows > 0)
            {
                return new OperationResult<int> { Success = true };
            }
            return new OperationResult<int> { Success= false };

        }
    }
}
