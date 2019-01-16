using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FewBox.Core.Web.Dto;
using Microsoft.AspNetCore.Mvc;
using Sample_Istio_Rating.Dtos;

namespace Sample_Istio_Rating.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        [HttpGet("{id}")]
        public PayloadMetaResponseDto<RatingDto> Get(string id)
        {
            Random random = new Random();
            return new PayloadMetaResponseDto<RatingDto>{
                Payload = new RatingDto { Star = random.Next(1, 5) }
            };
        }
    }
}
