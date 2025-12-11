using BancoDigitalUno.Domain.Interfaces.UoW;
using System.Web.Mvc;

namespace BancoDigitalUno.Web.Controllers
{
    public class ContasController : Controller
    {
        #region "Attributes"

        private readonly IUnitOfWork _unitOfWork;

        #endregion


        #region "Constructor"

        public ContasController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        #endregion


        #region "Index"

        /// <summary>
        /// Recovery
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var contasDomain = (_unitOfWork.ContaRepository.GetAll());

            return View(contasDomain);
        }

        #endregion
    }
}