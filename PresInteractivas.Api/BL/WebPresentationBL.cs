using PresInteractivas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresInteractivas.Api.BL
{
    public class WebPresentationBL
    {
        /// <summary>
        /// Metodo que devuelve el listado de presentaciones
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<PresentacionDto>> GetPresentations()
        {
            return await presentationsMokup();
        }

        /// <summary>
        /// Metodo para agregar una presentación
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<PresentacionDto> AddPresentation(PresentacionDto data)
        {
            _presentationsMokup.Add(item: data);

            return data;
        }

        private List<PresentacionDto> _presentationsMokup = new List<PresentacionDto>()
            {
                new PresentacionDto()
                {
                    id = 1,
                    name = "Presentacion Uno",
                    dateCreation = DateTime.Now,
                    userCreates = 1
                },
                new PresentacionDto()
                {
                    id = 2,
                    name = "Presentacion Dos",
                    dateCreation = DateTime.Now,
                    userCreates = 2
                }
            };

        private async Task<List<PresentacionDto>> presentationsMokup()
        {
            var presenMokup = _presentationsMokup;
            return presenMokup;
        }
    }
}
