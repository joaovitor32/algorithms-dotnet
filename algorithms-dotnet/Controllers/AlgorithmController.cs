using algorithms_dotnet.Services.Bubblesort;
using algorithms_dotnet.Services.InsertionSort;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace algorithms_dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlgorithmController : Controller
    {

        public IBubblesortService _bubbleSortService;
        public IInsertionService _insertionSortService;

        public AlgorithmController(IBubblesortService bubbleSortService, IInsertionService insertionSortService)
        {
           _bubbleSortService = bubbleSortService ?? throw new ArgumentNullException(nameof(_bubbleSortService));
           _insertionSortService = insertionSortService ?? throw new ArgumentNullException(nameof(_insertionSortService));
        }

        [HttpGet("bubblesort/children")]
        public int[] Bubblesort([FromQuery(Name = "array")] int[] array)
        {
            return _bubbleSortService.Sort(array);
        }
        [HttpGet("insertionsort/children")]
        public int[] Insertionsort([FromQuery(Name = "array")] int[] array)
        {
            return _insertionSortService.Sort(array);
        }
    }
}
