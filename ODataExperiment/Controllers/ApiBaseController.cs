using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataExperiment.Controllers
{
    [ApiController]
    [Route("api/odata/[controller]")]
    [ApiExplorerSettings(IgnoreApi = false)]
    public class ApiBaseController : ODataController //ControllerBase
    {

    }
}
