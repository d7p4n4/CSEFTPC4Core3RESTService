using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSEFTPC4Core3Cap;
using CSEFTPC4Core3Objects.Ac4yObjects;
using CSEFTPC4Core3ObjectService.ObjectServices;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static CSEFTPC4Core3ObjectService.ObjectServices.Ac4yPersistentChildEFService;

namespace CSEFTPC4Core3RESTService.Controllers
{
    public class Ac4yODataController : ODataController
    {
        [HttpGet]
        [EnableQuery]
        public IEnumerable<Ac4yPersistentChild> Get()
        {
            return new Ac4yPersistentChildEFService().GetList(new Ac4yPersistentChildEFService.GetListRequest()).Ac4yPersistentChilds;
        }
        
        [HttpDelete]
        [EnableQuery]
        public IActionResult Delete([FromODataUri] int key)
        {
            return Ok(new Ac4yPersistentChildEFService().DeleteById(new DeleteByIdRequest() { Id = key }));
        }

        [HttpPatch]
        [EnableQuery]
        public IActionResult Patch([FromODataUri] int key, [FromBody] Delta<Ac4yPersistentChild> request)
        {
            UpdateByIdResponse response =
                new Ac4yPersistentChildEFService().UpdateById(new UpdateByIdRequest()
                {
                    Id = key,
                    Ac4yPersistentChild = request.GetInstance()
                }); 

            return Ok(response);
        }
        
        [HttpPost]
        [EnableQuery]
        public InsertResponse Post([FromBody] Ac4yPersistentChild ac4yPersistentChild)
        {
            return new Ac4yPersistentChildEFService().Insert(new InsertRequest() { Ac4yPersistentChild = ac4yPersistentChild });
        }
    }
}