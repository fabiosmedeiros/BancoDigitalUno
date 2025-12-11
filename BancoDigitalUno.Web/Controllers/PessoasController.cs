using BancoDigitalUno.Domain.Interfaces.UoW;
using System.Web.Mvc;

namespace BancoDigitalUno.Web.Controllers
{
    public class PessoasController : Controller
    {
        #region "Attributes"

        private readonly IUnitOfWork _unitOfWork;

        #endregion


        #region "Constructor"

        public PessoasController(IUnitOfWork unitOfWork)
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
            var pessoasDomain = (_unitOfWork.PessoaRepository.GetAll());

            return View(pessoasDomain);
        }

        #endregion
    }
}