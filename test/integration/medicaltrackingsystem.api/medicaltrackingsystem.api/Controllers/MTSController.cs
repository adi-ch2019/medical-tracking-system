using Microsoft.AspNetCore.Mvc;
using medicaltrackingsystem.api.Data;

namespace medicaltrackingsystem.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MTSController : ControllerBase
    {
        private IMTSService _service;

        public MTSController(IMTSService service)
        {
            _service = service;
        }

        //Create/Add a new medicine
        [HttpPost("AddMedicine")]
        public IActionResult AddMedicine([FromBody] Medicine medicine)
        {
            try
            {
                if (medicine.FullNameOfMedicine != null && medicine.Price != null && medicine.Quantity != null)
                {
                    _service.AddMedicine(medicine);
                    return Ok(medicine);
                }
                return BadRequest("Medicine was not added");
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        //Read all books
        [HttpGet("[action]")]
        public IActionResult GetMedicines()
        {
            var allMedicines = _service.GetAllMedicines();
            return Ok(allMedicines);
        }

        [HttpPut("UpdateMedicine/{id}")]
        public IActionResult UpdateMedicine(string id, [FromBody] Medicine medicine)
        {
            _service.UpdateMedicine(id, medicine);
            return Ok(medicine);
        }

        //Delete a medicine
        [HttpDelete("DeleteMedicine/{id}")]
        public IActionResult DeleteMedicine(string id)
        {
            _service.DeleteMedicine(id);
            return Ok();
        }

        //Get a single medicine by id
        [HttpGet("SingleMedicine/{id}")]
        public IActionResult GetMedicineById(string id)
        {
            var medicine = _service.GetMedicineById(id);
            return Ok(medicine);
        }

    }
}
