using CharacterApp.Models.CharacterModels;
using CharacterApp.Services.CharacterServices;
using Microsoft.AspNet.Identity;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace CharacterApp.WebAPI.Controllers.Character_Controller
{
    public class CharacterController : ApiController
    {
        private CharacterServices CreateCharacterService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var svc = new CharacterServices(userId);
            return svc;
        }

        [HttpPost]
        public async Task<IHttpActionResult> Post([FromBody] CharacterCreate character)
        {
            if (character is null || !ModelState.IsValid)
                return BadRequest(ModelState);

            var svc = CreateCharacterService();
            var success = await svc.Post(character);

            if (success)
                return Ok("You created a character!");

            return InternalServerError();
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            var svc = CreateCharacterService();
            var characters = await svc.Get();
            return Ok(characters);
        }
    }
}
