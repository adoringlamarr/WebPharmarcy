using Microsoft.AspNetCore.Mvc;

namespace WebPharmarcy.Api;

[ApiController]
public class TestApi
{
   [HttpGet, Route("ping")]
   public String Ping() => "pong";
}
