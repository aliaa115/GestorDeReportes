using System;
using System.Collections.Generic;
using capaDatoRpt.Conexion;
using capaDatoRpt.Entity;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaControlRpt.Control
{
    public class PropiedadReporteControl
    {
        private Transaccion transaccion = new Transaccion();

        public void insertarPropiedadReporte(PropiedadReporte propiedad)
        {
            try
            {
                String sComando = String.Format("INSERT INTO Tbl_Propiedad_Rpt VALUES ({0}, '{1}', {2}, {3}, {4}, {5}); ",
                    propiedad.REPORTE.REPORTE.ToString(), propiedad.USUARIO.USUARIO, propiedad.APLICACION.APLICACION,
                    propiedad.MODULO.MODULO.ToString(), propiedad.IMPRIMIR.ToString(), propiedad.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error al insertar configuracion para PROPIEDADES.");
            }
        }

        public void insertarPropiedadReporteSinApp(PropiedadReporte propiedad)
        {
            try
            {
                String sComando = String.Format("INSERT INTO Tbl_Propiedad_Rpt VALUES ({0}, '{1}', 0, {3}, {4}, {5}); ",
                    propiedad.REPORTE.REPORTE.ToString(), propiedad.USUARIO.USUARIO, "", propiedad.MODULO.MODULO.ToString(), 
                    propiedad.IMPRIMIR.ToString(), propiedad.ESTADO.ToString());
                this.transaccion.insertarDatos(sComando);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error al insertar configuracion para PROPIEDADES.");
            }
        }

        public void modificarPropiedadReporte(PropiedadReporte propiedad)
        {
            try
            {
                String sComando = String.Format("UPDATE Tbl_Propiedad_Rpt " +
                    "SET  imprimir = {4}, estado = {5} " +
                    "WHERE PK_id_reporte = {0} and PK_id_usuario = '{1}' and PK_id_aplicacion = {2} and PK_id_modulo = {3}; ",
                   propiedad.REPORTE.REPORTE.ToString(), propiedad.USUARIO.USUARIO, propiedad.APLICACION.APLICACION,
                   propiedad.MODULO.MODULO.ToString(), propiedad.IMPRIMIR.ToString(), propiedad.ESTADO.ToString());
                this.transaccion.insertarDatos(sComando);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error al insertar configuracion para PROPIEDADES.");
            }
        }

        public void modificarPropiedadReporteSinApp(PropiedadReporte propiedad)
        {
            try
            {
                String sComando = String.Format("UPDATE Tbl_Propiedad_Rpt " +
                    "SET PK_id_usuario = '{1}', PK_id_modulo = {3}, imprimir = {4}, estado = {5}" +
                    "WHERE PK_id_reporte = {0}; ",
                   propiedad.REPORTE.REPORTE.ToString(), propiedad.USUARIO.USUARIO, propiedad.APLICACION.APLICACION,
                   propiedad.MODULO.MODULO.ToString(), propiedad.IMPRIMIR.ToString(), propiedad.ESTADO.ToString());
                this.transaccion.insertarDatos(sComando);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error al insertar configuracion para PROPIEDADES.");
            }
        }

        public PropiedadReporte obtenerPropiedadPorUsuarioAplicacion(string usuario, int aplicacion, int modulo)
        {
            PropiedadReporte propiedad = new PropiedadReporte();
            ReporteControl rpt = new ReporteControl();
            Usuario usu = new Usuario();
            AplicacionControl app = new AplicacionControl();
            ModuloControl mdl = new ModuloControl();
            UsuarioControl usuControl = new UsuarioControl();
            try
            {
                String sComando = String.Format("SELECT * FROM Tbl_Propiedad_Rpt " +
                    "WHERE PK_id_usuario = '{0}' AND PK_id_aplicacion = {1} AND PK_id_modulo = {2} AND estado <> 0;",
                   usuario, aplicacion,modulo);

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        propiedad.REPORTE = rpt.obtenerReporte(reader.GetInt32(0));
                        propiedad.USUARIO = usuControl.SetUsuario(reader.GetString(1));
                        propiedad.APLICACION =  reader.IsDBNull(2) ? null : app.obtenerAplicacion(reader.GetInt32(2), reader.GetInt32(3));
                        propiedad.MODULO = mdl.obtenerModulo(reader.GetInt32(3));
                        propiedad.IMPRIMIR = reader.GetInt32(4);
                        propiedad.ESTADO = reader.GetInt32(5);
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error al insertar configuracion para PROPIEDADES.");
            }
            return propiedad;
        }

        public PropiedadReporte obtenerPropiedadPorUsuarioModulo(int reporte, string usuario, int modulo)
        {
            PropiedadReporte propiedad = new PropiedadReporte();
            ReporteControl rpt = new ReporteControl();
            AplicacionControl app = new AplicacionControl();
            ModuloControl mdl = new ModuloControl();
            UsuarioControl usuControl = new UsuarioControl();

            try
            {
                String sComando = String.Format("SELECT PK_id_reporte, PK_id_usuario,  PK_id_modulo, imprimir, estado FROM Tbl_Propiedad_Rpt " +
                    "WHERE PK_id_reporte={0} AND PK_id_usuario = '{1}' AND PK_id_modulo = {3};",
                   reporte, usuario, "", modulo);

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        propiedad.REPORTE = rpt.obtenerReporte(reader.GetInt32(0));
                        propiedad.USUARIO = usuControl.SetUsuario(reader.GetString(1));
                        propiedad.MODULO = mdl.obtenerModulo(modulo);
                        propiedad.IMPRIMIR = reader.GetInt32(3);
                        propiedad.ESTADO = reader.GetInt32(4);
                    }
                }else
                {
                    return null;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error al insertar configuracion para PROPIEDADES.");
            }
            return propiedad;
        }
        public List<PropiedadReporte> obtenerAllPropiedad()
        {
            List < PropiedadReporte> propiedadList = new List<PropiedadReporte>();
            ReporteControl rpt = new ReporteControl();
            Usuario usu = new Usuario();
            AplicacionControl app = new AplicacionControl();
            ModuloControl mdl = new ModuloControl();
            UsuarioControl usuControl = new UsuarioControl();

            try
            {
                String sComando = String.Format("SELECT PK_id_reporte, PK_id_usuario, PK_id_aplicacion, " +
                    "PK_id_modulo, imprimir, estado FROM Tbl_Propiedad_Rpt; ");

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        PropiedadReporte propiedadTmp = new PropiedadReporte();
                        propiedadTmp.REPORTE = rpt.obtenerReporte(reader.GetInt32(0));
                        propiedadTmp.USUARIO = usuControl.SetUsuario(reader.GetString(1));
                        propiedadTmp.APLICACION = reader.IsDBNull(2) ? null : app.obtenerAplicacion(reader.GetInt32(2), reader.GetInt32(3));
                        propiedadTmp.MODULO = mdl.obtenerModulo(reader.GetInt32(3));
                        propiedadTmp.IMPRIMIR = reader.GetInt32(4);
                        propiedadTmp.ESTADO = reader.GetInt32(5);
                        propiedadList.Add(propiedadTmp);
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error al insertar configuracion para PROPIEDADES.");
            }
            return propiedadList;
        }
    }
}
