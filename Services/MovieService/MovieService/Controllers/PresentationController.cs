using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieService.Controllers
{
    [Route("api/presentations")]
    [ApiController]
    public class PresentationController : ControllerBase
    {
        private readonly Services.PresentationService _presentationService;

        public PresentationController(Services.PresentationService presentationService)
        {
            this._presentationService = presentationService; 
        }
    }
}
