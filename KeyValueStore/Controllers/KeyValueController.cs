using KeyValueStore;
using Marten;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class KeyValueController : ControllerBase
{
    private readonly IDocumentSession _session;

    public KeyValueController(IDocumentSession session)
    {
        _session = session;
    }

    [HttpGet("{key}")]
    public async Task<IActionResult> Get(string key)
    {
        var record = await _session.Query<KeyValueRecord>().FirstOrDefaultAsync(x => x.Key == key);
        if (record == null)
        {
            return NotFound();
        }
        return Ok(record.Data);
    }

    [HttpPost("{key}")]
    public async Task<IActionResult> Post(string key, [FromBody] KeyValueRecord data)
    {
        var record = new KeyValueRecord(key, data.Data); // `data.Data` şeklinde alıyoruz
        _session.Store(record);
        await _session.SaveChangesAsync();
        return Ok();
    }

    [HttpDelete("{key}")]
    public async Task<IActionResult> Delete(string key)
    {
        _session.DeleteWhere<KeyValueRecord>(x => x.Key == key);
        await _session.SaveChangesAsync();
        return Ok();
    }
}
