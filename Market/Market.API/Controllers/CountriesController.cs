using Market.API.Data;
using Market.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Market.API.Controllers
{

    [ApiController]
    [Route("/api/countries")]
    public class CountriesController:ControllerBase
    {


        private readonly DataContext _Context;

        public CountriesController(DataContext context)
        {
            _Context = context;
        }


        //lista de paises

        public async Task<ActionResult> Get()
        {


            return Ok(await _Context.Countries.ToListAsync());

        }

        //get por parametro -- id
        [HttpGet("{id:int}")]

        public async Task<ActionResult> Get(int id) {

            var country = await _Context.Countries.FirstOrDefaultAsync
                (c => c.Id == id);

            if (country == null)
            {
                return NotFound();
            }

            return Ok(country);

        
        
        }

        // Insertar registros

        [HttpPost]
        public async Task<ActionResult> Post(Country country)
        {
            _Context.Add(country);
            await _Context.SaveChangesAsync();
            return Ok(country);//200
        }


        [HttpPut]
        public async Task<ActionResult> Put(Country country)
        {
            _Context.Update(country);
            await _Context.SaveChangesAsync();
            return Ok(country);//200
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaafectada = await _Context.Countries
                .Where(c => c.Id == id)
                .ExecuteDeleteAsync();

            if (filaafectada == 0)
            {


                return NotFound();// 404

            }

            return NoContent();//204   

        }


    }
}
