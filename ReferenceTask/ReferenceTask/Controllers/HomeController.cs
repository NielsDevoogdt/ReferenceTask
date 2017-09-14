using ReferenceTask.Domain.Repositories;
using System.Threading.Tasks;
using System.Web.Mvc;
using ReferenceTask.Persistence.Services;

namespace ReferenceTask.Controllers
{
    public class HomeController : Controller
    {

        //public JokeRepository jokerepo;
        // GET: Home
        //public async Task<ActionResult> Index()
        //{
        //    //force test
        //    //JokeRepository jokerepo = new JokeRepository();
        //    //jokerepo = new JokeRepository(new JokeApiService());
        //    //var jokes = await jokerepo.GetJokes();

        //    //   return View("Home"); om te forceren naar home
        //    //return Viekw(jokes);
        //}


        //public ActionResult List(Joke)
        public ActionResult ListJokes()

        {

            //api aanspreken


            //var model = new Joke();
            //model.Rating

            //   return View("Home"); om te forceren naar home
            return View();
        }










    }
}