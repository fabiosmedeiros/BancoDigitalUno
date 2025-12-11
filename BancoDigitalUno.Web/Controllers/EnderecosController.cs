using BancoDigitalUno.Domain.Interfaces.UoW;
using System.Web.Mvc;

namespace BancoDigitalUno.Web.Controllers
{
    public class EnderecosController : Controller
    {
        #region "Attributes"

        private readonly IUnitOfWork _unitOfWork;

        #endregion


        #region "Constructor"

        public EnderecosController(IUnitOfWork unitOfWork)
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
            var enderecosDomain = (_unitOfWork.EnderecoRepository.GetAll());

            return View(enderecosDomain);
        }

        #endregion
    }
}