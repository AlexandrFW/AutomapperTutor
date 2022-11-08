using AutoMapper;
using AutomapperTutor.Model.DTO;
using AutomapperTutor.Model.Statistics;
using Microsoft.AspNetCore.Mvc;

namespace AutomapperTutor.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SaveStatisticController : Controller
{
    private readonly IMapper _mapper;

    private Statistics statistics = new Statistics
    {
        EquipmentSN = "1234567",

        ProductName = "PIROG,RU,CHERY",

        ProdCode = "0349867",

        AverageTrans = 467.43,

        PercentTu1TotalTrans = 1.8,

        TransAccepted = 10986,

        TransTO2 = 0,

        TransTO1 = 467,

        TransTooHeavy = 0,

        TransTooLight = 0,

        CurrentWeight = 455.23,

        PermanentTooLight = 0,

        PermanentAccepted = 10986,

        PermanentTooHeavy = 0,

        PermanentTotal = 10986
    };

    private Machine machine = new Machine
    {
        IdLines = 12,
        LinesName = "CHARY-BAKE",
        IdScale = 45,
        IdLinesFwn = 37,
        SerialNum = "1234567",
        IPAddress = "192.168.0.23"
    };

    private Product product = new Product
    {
        ProdCode = "0349867",

        ProductName = "PIROG,RU,CHERY",

        Performance = 90,

        Length = 45,

        CorrFactor = 0.000,

        Nominal = 450.0,

        TU = 438.0,

        TO = 472.0,

        Tara = 20.0
    };

    public SaveStatisticController(IMapper mapper)
    {
        _mapper = mapper;
    }

    [HttpGet]
    public ActionResult GetIndividualWeight()
    {
        var individualWeight = _mapper.Map<IndividualWeightDTO>((statistics, machine, product));

        return Ok(individualWeight);
    }
}
