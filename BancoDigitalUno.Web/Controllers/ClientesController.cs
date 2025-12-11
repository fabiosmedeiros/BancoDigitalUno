using BancoDigitalUno.Domain.Interfaces.UoW;
using System.Web.Mvc;

namespace BancoDigitalUno.Web.Controllers
{
    public class ClientesController : Controller
    {
        #region "Attributes"

        private readonly IUnitOfWork _unitOfWork;

        #endregion


        #region "Constructor"

        public ClientesController(IUnitOfWork unitOfWork)
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
            var clientesDomain = (_unitOfWork.ClienteRepository.GetAll());

            return View(clientesDomain);
        }

        #endregion
    }
}