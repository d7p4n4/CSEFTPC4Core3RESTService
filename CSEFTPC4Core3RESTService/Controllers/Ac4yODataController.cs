using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSEFTPC4Core3Objects.Ac4yObjects;
using CSEFTPC4Core3ObjectService.ObjectServices;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static CSEFTPC4Core3ObjectService.ObjectServices.Ac4yPersistentChildEFService;

namespace CSEFTPC4Core3RESTService.Controllers
{
    [Route("odata/[controller]")]
    public class Ac4yODataController : ODataController
    {
        [HttpGet]
        [EnableQuery]
        public IActionResult GetAc4yPersistentChildList()
        {

            return Ok(new Ac4yPersistentChildEFService().GetList(new Ac4yPersistentChildEFService.GetListRequest()).Ac4yPersistentChilds);
        }

        [HttpDelete]
        [EnableQuery]
        public IActionResult DeleteAc4yPersistentChild([FromBody] DeleteByIdRequest request)
        {
            return Ok(new Ac4yPersistentChildEFService().DeleteById(request));
        }

        [HttpPatch]
        [EnableQuery]
        public IActionResult UpdateAc4yPersistentChild([FromBody] UpdateByIdRequest request)
        {
            return Ok(new Ac4yPersistentChildEFService().UpdateById(request));
        }
        
        [HttpPost]
        [EnableQuery]
        public InsertResponse Insert([FromBody] InsertRequest request)
        {
            return new Ac4yPersistentChildEFService().Insert(request);
        }
    }
}