using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSEFTPC4Core3ObjectService.ObjectServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using static CSEFTPC4Core3ObjectService.ObjectServices.Ac4yPersistentChildEFService;

namespace EFRESTService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ac4yPersistentChildController : ControllerBase
    {

        [HttpPost]
        [Route("/getbyid")]
        public GetByIdResponse GetById(GetByIdRequest request)
        {
            return new Ac4yPersistentChildEFService().GetById(request);
        }
        
        [HttpPost]
        [Route("/getbyguid")]
        public GetByGuidResponse GetByGuid(GetByGuidRequest request)
        {
            return new Ac4yPersistentChildEFService().GetByGuid(request);
        }
        
        [HttpPost]
        [Route("/isexistbyid")]
        public IsExistByIdResponse IsExistById(IsExistByIdRequest request)
        {
            return new Ac4yPersistentChildEFService().IsExistById(request);
        }
        
        [HttpPost]
        [Route("/isexistbyguid")]
        public IsExistByGuidResponse IsExistByGuid(IsExistByGuidRequest request)
        {
            return new Ac4yPersistentChildEFService().IsExistByGuid(request);
        }
        
        [HttpPost]
        [Route("/updatebyid")]
        public UpdateByIdResponse UpdateById(UpdateByIdRequest request)
        {
            return new Ac4yPersistentChildEFService().UpdateById(request);
        }
        
        [HttpPost]
        [Route("/updatebyguid")]
        public UpdateByGuidResponse UpdateByGuid(UpdateByGuidRequest request)
        {
            return new Ac4yPersistentChildEFService().UpdateByGuid(request);
        }
        
        [HttpPost]
        [Route("insert")]
        public InsertResponse Insert(InsertRequest request)
        {
            return new Ac4yPersistentChildEFService().Insert(request);
        }
        
        [HttpPost]
        [Route("/setbyguid")]
        public SetByGuidResponse SetByGuid(SetByGuidRequest request)
        {
            return new Ac4yPersistentChildEFService().SetByGuid(request);
        }    } // Ac4yPersistentChildController
} // EFRESTService.Controllers