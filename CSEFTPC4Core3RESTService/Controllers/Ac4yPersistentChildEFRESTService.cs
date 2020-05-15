using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CSEFTPC4Core3ObjectService.ObjectServices;
using static CSEFTPC4Core3ObjectService.ObjectServices.Ac4yPersistentChildEFService;

namespace CSEFTPC4Core3EFRESTService.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class Ac4yPersistentChildController : ControllerBase
    {

        [HttpGet]
        [Route("getbyid")]
        public GetByIdResponse GetById(GetByIdRequest request)
        {
            return new Ac4yPersistentChildEFService().GetById(request);
        }

        [HttpGet]
        [Route("getbyid/{id}")]
        public GetByIdResponse GetById([FromRoute] int id)
        {
            return new Ac4yPersistentChildEFService().GetById(new GetByIdRequest() { Id = id });
        }
        
        [HttpGet]
        [Route("getbyguid")]
        public GetByGuidResponse GetByGuid(GetByGuidRequest request)
        {
            return new Ac4yPersistentChildEFService().GetByGuid(request);
        }
        
        [HttpGet]
        [Route("getbyguid/{giud}")]
        public GetByGuidResponse GetByGuid([FromRoute] string guid)
        {
            return new Ac4yPersistentChildEFService().GetByGuid(new GetByGuidRequest() { Guid = guid });
        }
        
        [HttpGet]
        [Route("isexistbyid")]
        public IsExistByIdResponse IsExistById(IsExistByIdRequest request)
        {
            return new Ac4yPersistentChildEFService().IsExistById(request);
        }
        
        [HttpGet]
        [Route("isexistbyid/{id}")]
        public IsExistByIdResponse IsExistById([FromRoute] int id)
        {
            return new Ac4yPersistentChildEFService().IsExistById(new IsExistByIdRequest() { Id = id });
        }
        
        [HttpGet]
        [Route("isexistbyguid")]
        public IsExistByGuidResponse IsExistByGuid(IsExistByGuidRequest request)
        {
            return new Ac4yPersistentChildEFService().IsExistByGuid(request);
        }
        
        [HttpGet]
        [Route("isexistbyguid/{guid}")]
        public IsExistByGuidResponse IsExistByGuid([FromRoute] string guid)
        {
            return new Ac4yPersistentChildEFService().IsExistByGuid(new IsExistByGuidRequest() { Guid = guid });
        }
        
        [HttpPost]
        [Route("updatebyid")]
        public UpdateByIdResponse UpdateById(UpdateByIdRequest request)
        {
            return new Ac4yPersistentChildEFService().UpdateById(request);
        }
        
        [HttpPost]
        [Route("updatebyguid")]
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
        [Route("setbyguid")]
        public SetByGuidResponse SetByGuid(SetByGuidRequest request)
        {
            return new Ac4yPersistentChildEFService().SetByGuid(request);
        }    } // Ac4yPersistentChildController
} // EFRESTService.Controllers