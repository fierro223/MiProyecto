using DDJJAdministrator.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDJJAdministrator.Services.Validaciones
{
    public class ValidacionesServicio
    {
        public string DatosPersonalesValidados(DatosPersonales datosValidacion,byte formulario)
        {
            if(formulario == 2)
            {
                if (datosValidacion.Viajes == null)
                {
                    return "Tenes que elegir una opcion de viaje";
                }
                
            }
          
            if (datosValidacion.NDniOPasaporte.Trim().Length == 0) return "El documento no puede estar vacio";

            if (datosValidacion.NDniOPasaporte.Trim().Length != 8) return "El documento no puede tener mas de 8 digitos";

            if (datosValidacion.NombreEmpresa.Trim().Length == 0) return "El nombre de la empresa no puede estar vacio";

            if (datosValidacion.Mail.Trim().Length == 0) return "El mail no puede estar vacio";

            if (datosValidacion.Nombre.Trim().Length == 0) return "El nombre no deve estar vacio";

            if (datosValidacion.Apellido.Trim().Length == 0) return "El Apellido no deve estar vacio";

            if (datosValidacion.Telefono.Trim().Length == 0) return "El telefono no tien que estar vacio";

            if (datosValidacion.Telefono.Trim().Length != 8) return "El telefono tien que tener 8 digitos";

            if (datosValidacion.CodigoDeAria.Trim().Length != 3) return "El codigo de aria no deve estar vacio";

            if (int.Parse(datosValidacion.edad)<18) return "Tiene que Ser mayor de dedad";

            if (datosValidacion.IdGenero == 0) return "Deve llenar el campo de genero";

            if (datosValidacion.GrupoRiesgo == null) return "Deves completar la opiones de Grupo de riesgo";

            if (datosValidacion.Vacunas == null) return "Deves completar la opcion del campo vacuna";

            if (datosValidacion.FechaDeNacimiento == DateTime.Now.Date) return "Deves elegir una fecha de Nacimiento ";

            if (datosValidacion.FechaDeIngreso < DateTime.Now.Date) return "La declaracion jurada deve estar actualizada al dia de hoy o superior";

            if (datosValidacion.IdCodigoPais == 0) return "Se nesesita una Codigo de Pais";

            if (datosValidacion.IdNacional == 0) return "Deves indicar un pais";

            if (datosValidacion.IdResidencia == 0) return "Daves indicar una Pais de residencia";

            if (datosValidacion.IdDepartamentos == 0) return "Deves Indicar que aria quieres Ingresar";

            return string.Empty;
        }
        public string ContactoCovidValidar(ContatoCovid contatoCovid)
        {
            if (contatoCovid.PersonaExterior == null) return "Deve completar el campo Persona en el exterior";

            if (contatoCovid.ContactoExtrecho == null) return "Deve indicar una de las obciones de contrato extrecho";

            if (contatoCovid.CasoSopechoso == null) return "Deve indicar una de las obciones de Casos sospechosos";

            if (contatoCovid.PresentaSintoma == null) return "Deve indicar una de las obciones de los sintomas";

            return string.Empty;

        }
    }
}
