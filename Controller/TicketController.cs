using Microsoft.AspNetCore.Mvc;
using RepairManager.Entity;

namespace RepairManager.Controller;


[ApiController]
[Route("api/v1/ticket")]
public class TicketController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Ticket>> getTicketList(){
        List<Ticket> ticketList = new List<Ticket>();
     
        ticketList.Add(new Ticket(){
            Id=1,
            CustomerName="clienteTest",
            CustomerPhone="phoneTest",
            CustomerAddress="AddressTest",
            TaskDescription="DescriptionTest"});
        Console.WriteLine("buenasssssssss");
    
        return ticketList;
    }

}
