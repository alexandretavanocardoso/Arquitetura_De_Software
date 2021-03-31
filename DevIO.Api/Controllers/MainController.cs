using DevIO.Api.Cross.Enumerators;
using DevIO.Api.Cross.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DevIO.Api.Controllers
{
    public class MainController : ControllerBase
    {
        protected ActionResult CustomResponse(ResultadoExecucaoQuery rExecucao)
        {
            if (rExecucao.GetHttpStatusCode().HasValue)
                return StatusCode(rExecucao.GetHttpStatusCode().Value, rExecucao);
            else if (rExecucao.ResultadoExecucaoEnum == (int)ResultadoExecucaoEnum.Sucesso)
                return Ok(rExecucao);
            else
                return BadRequest(rExecucao);
        }

        protected ActionResult CustomResponseModelInvalid(ModelStateDictionary ModelState)
        {
            ResultadoExecucaoQuery<Dictionary<string, List<string>>> rExecucao = new ResultadoExecucaoQuery<Dictionary<string, List<string>>>()
            {
                ResultadoExecucaoEnum = (int)ResultadoExecucaoEnum.Erro,
                Mensagem = "Formato do parâmetro inválido!"
            };

            Dictionary<string, List<string>> listaErros = new Dictionary<string, List<string>>();

            foreach (var modelStateKey in ModelState.Keys)
            {
                List<string> erros = new List<string>();

                var value = ModelState[modelStateKey];

                foreach (var error in value.Errors)
                    erros.Add(error.ErrorMessage);

                listaErros.Add(modelStateKey, erros);
            }

            rExecucao.Data = listaErros;

            return BadRequest(rExecucao);
        }

        protected string GetUserFromToken()
        {
            var identity = (HttpContext.User.Identity as ClaimsIdentity);

            if (identity != null)
                return identity.Name;
            else
                return null;
        }
    }
}
