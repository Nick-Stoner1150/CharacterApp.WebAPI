using CharacterApp.Services.FeatureModel;
using CharacterApp.Services.FeatureService;
using Microsoft.AspNet.Identity;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace CharacterApp.WebAPI.Controllers
{
    public class FeatureController : ApiController
    {
        private FeatureService CreateFeature()
        {
            var featureId = Guid.Parse(User.Identity.GetUserId());
            var svc = new FeatureService(featureId);
            return svc;
        }
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            var svc = CreateFeature();
            var feature = await svc.Get();
            return Ok(feature);
        }
        [HttpPost]
        public async Task<IHttpActionResult> Post(FeatureCreate feature)
        {
            if (feature is null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var svc = CreateFeature();
            var success = await svc.Post(feature);
            if (success)
            {
                return Ok();
            }
            return InternalServerError();
        }
        [HttpPut]
        public async Task<IHttpActionResult> Put(FeatureEdit feature, int id)
        {
            if (id<1 || id!=feature.Id || feature is null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var svc = CreateFeature();
            var success = await svc.Put(feature, id);
            if (success)
            {
                return Ok();
            }
            return InternalServerError();
        }
    }
}
