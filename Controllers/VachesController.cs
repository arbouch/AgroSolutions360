using AgroSolutions360.Interfaces;
using AgroSolutions360.Models.Dtos.Vache;
using AgroSolutions360.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgroSolutions360.Controllers
{
    public class VachesController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVachesService _vachesService;

        public VachesController(ILogger<HomeController> logger, IVachesService vachesService)
        {
            _logger = logger;
            _vachesService = vachesService;

        }
        [HttpGet("api/vache/recherche")]
        public OperationResult<List<VacheDto>> RechercheVache()
        {
            return _vachesService.RechercheVaches();
        }
        [HttpGet("api/vache/GetById")]
        public OperationResult<VacheDto> GetVacheById(int IdVache)
        {
            return _vachesService.GetVacheById(IdVache);
        }
        [HttpPost("api/vache/Add")]
        public OperationResult<NewVacheDto> AjoutVache([FromBody] NewVacheDto newVacheDto)
        {
            return _vachesService.AjoutVache(newVacheDto);
        }

        [HttpPut("api/vache/Update")]
        public OperationResult<UpdateVacheDto> ModificationVache([FromBody] UpdateVacheDto updateVacheDto)
        {
            return _vachesService.ModificationVache(updateVacheDto);
        }
        [HttpDelete("api/vache/Delete")]
        public OperationResult<int> SupprimerVache(int SupprimerVacheId)
        {
            return _vachesService.SupprimerVache(SupprimerVacheId);
        }
    }
}
