using DemoTU.Controllers;
using DemoTU.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoTU.Tests;

public class DiplomeControllerTest
{
    private AnnuaireContextMock _contextMock = new AnnuaireContextMock();

    public void Dispose() => _contextMock.Dispose();

    [Fact]
    public async void GetDiplome_Returns_All_Diplomas()
    {
        DiplomesController diplomesController = new DiplomesController(_contextMock.Context);

        ActionResult<IEnumerable<Diplome>> diplomes = await diplomesController.GetDiplomes();

        ActionResult<IEnumerable<Diplome>> actionResult = Assert.IsType<ActionResult<IEnumerable<Diplome>>>(diplomes);
        List<Diplome> returnValue = Assert.IsType<List<Diplome>>(actionResult);
        Assert.Equal(_contextMock.Context.Diplomes.Count(), returnValue.Count);
    }

    [Fact]
    public async void GetDiplome_CDA_Returns_Diploma_CDA()
    {
        const string code = "CDA";
        DiplomesController diplomesController = new DiplomesController(_contextMock.Context);

        ActionResult<Diplome> diplomes = await diplomesController.GetDiplomes(code);

        ActionResult<Diplome> actionResult = Assert.IsType<ActionResult<Diplome>>(diplomes);
        Diplome returnValue = Assert.IsType<Diplome>(actionResult.Value);
        Assert.Equal(code, returnValue.Code);
    }

    [Fact]
    public async void GetDiplome_NCDA_Returns_NotFound()
    {
        const string code = "NCDA";
        DiplomesController diplomesController = new DiplomesController(_contextMock.Context);

        ActionResult<Diplome> diplomes = await diplomesController.GetDiplomes(code);

        ActionResult<Diplome> actionResult = Assert.IsType<ActionResult<Diplome>>(diplomes);
        Assert.IsType<NotFoundResult>(actionResult.Result);
    }
}