using AgroSolutions360.Models.Dtos.Vache;
using AgroSolutions360.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgroSolutions360.Interfaces
{
    public interface IVachesService
    {
       public OperationResult<List<VacheDto>> RechercheVaches();
       public OperationResult<VacheDto> GetVacheById(int IdVache);
        public OperationResult<NewVacheDto> AjoutVache(NewVacheDto NewVache);
        public OperationResult<UpdateVacheDto> ModificationVache(UpdateVacheDto UpdateVache);
        public OperationResult<int> SupprimerVache(int SupprimerVacheId);
    }
}
