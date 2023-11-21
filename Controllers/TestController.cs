using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace JWTAuthentication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AufträgeController : Controller
    {
        private static List<string> values = new List<string>();

        [HttpGet("Mitarbeiter")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<string>> GetValues()
        {
            return Ok(values);
        }

        [HttpGet("Mitarbeiter/{id}")]
        [AllowAnonymous]
        public ActionResult<string> GetValueById(string id)
        {
            int index = GetIndexById(id);
            if (index != -1 && index < values.Count)
            {
                return Ok($"Value retrieved with ID {id}: {values[index]}");
            }
            else
            {
                return NotFound($"No value found with ID: {id}");
            }
        }

        private int GetIndexById(string id)
        {
            // Beispiel: Extrahiere die numerische ID aus dem "Mitarbeiter/"-Präfix
            if (id.StartsWith("Mitarbeiter/"))
            {
                string numericId = id.Substring("Mitarbeiter/".Length);
                if (int.TryParse(numericId, out int result))
                {
                    // Überprüfe, ob der Index in der Liste vorhanden ist
                    return result < values.Count ? result : -1;
                }
            }
            return -1;
        }

        [HttpPost("Mitarbeiter/{id}")]
        [AllowAnonymous]
        public ActionResult<string> PostValue(string id, [FromBody] string value)
        {
            values.Add(value);
            return Ok($"Received value: {value} with ID: {id}");
        }

        [HttpPut("Mitarbeiter/{id}")]
        [AllowAnonymous]
        public ActionResult<string> PutValue(string id, [FromBody] string value)
        {
            // Hier könntest du die ID verwenden, um die Daten zu aktualisieren
            // Im Beispiel wird die ID einfach in der Antwort zurückgegeben.
            return Ok($"Value updated with ID: {id} to: {value}");
        }

        [HttpDelete("Mitarbeiter/{id}")]
        [AllowAnonymous]
        public ActionResult<string> DeleteValue(string id)
        {
            // Hier könntest du die ID verwenden, um die Daten zu löschen
            // Im Beispiel wird die ID einfach in der Antwort zurückgegeben.
            return Ok($"Value deleted with ID: {id}");
        }
    }
}
