using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tpSimulacion.entidades;

namespace tpSimulacion
{
    public partial class TpSIM : Form
    {
        public TpSIM()
        {
            InitializeComponent();
            dgvTabla.AllowUserToAddRows = false;
            dgvTabla.Visible = false;
        }

        public int devolverTiempoPrimeraRotura(double RND)
        {
            var tiempoNuevaRotura = (int)Math.Truncate(1 + (RND * 20));
            return tiempoNuevaRotura;

        }

        public bool hayDisponibilidadTaller(List<Taller> listaTaller)
        {
            var bandera = false;
            for (var i = 0; i < 8; i++)
            {
                if (listaTaller[i].estado == "L")
                {
                    bandera = true;
                    break;
                }
            }
            return bandera;
        }

        public Taller traerTallerLibre(List<Taller> listaTaller)
        {
            var  taller = new Taller();
            for (var i = 0; i < 8; i++)
            {
                if (listaTaller[i].estado == "L")
                {
                    taller = listaTaller[i];
                    break;
                }
            }
            return taller;
        }

        public void mostrarTabla(Registro registro, List<Taller> listaTaller, List<Grua> listaGruas )
        {
            var fila2 = new string[]
            {
                            registro.reloj.ToString(),
                            registro.evento.ToString(),


                            listaTaller[0].finReparacion.ToString(),
                            listaTaller[1].finReparacion.ToString(),
                            listaTaller[2].finReparacion.ToString(),
                            listaTaller[3].finReparacion.ToString(),
                            listaTaller[4].finReparacion.ToString(),
                            listaTaller[5].finReparacion.ToString(),
                            listaTaller[6].finReparacion.ToString(),
                            listaTaller[7].finReparacion.ToString(),


                            listaTaller[0].estado.ToString(),
                            listaTaller[1].estado.ToString(),
                            listaTaller[2].estado.ToString(),
                            listaTaller[3].estado.ToString(),
                            listaTaller[4].estado.ToString(),
                            listaTaller[5].estado.ToString(),
                            listaTaller[6].estado.ToString(),
                            listaTaller[7].estado.ToString(),
                            registro.cantidadGruasCola.ToString(),
                            registro.PromedioTiempoReparacion.ToString(),
                            registro.tiempoMaximoReparacion.ToString(),
                            listaGruas[0].proximaLlegadaReparación.ToString() + "-" + listaGruas[0].estado.ToString(), 
                            listaGruas[1].proximaLlegadaReparación.ToString() + "-" + listaGruas[1].estado.ToString(),
                            listaGruas[2].proximaLlegadaReparación.ToString() + "-" + listaGruas[2].estado.ToString(),
                            listaGruas[3].proximaLlegadaReparación.ToString() + "-" + listaGruas[3].estado.ToString(),
                            listaGruas[4].proximaLlegadaReparación.ToString() + "-" + listaGruas[4].estado.ToString(),
                            listaGruas[5].proximaLlegadaReparación.ToString() + "-" + listaGruas[5].estado.ToString(),
                            listaGruas[6].proximaLlegadaReparación.ToString() + "-" + listaGruas[6].estado.ToString(),
                            listaGruas[7].proximaLlegadaReparación.ToString() + "-" + listaGruas[7].estado.ToString(),
                            listaGruas[8].proximaLlegadaReparación.ToString() + "-" + listaGruas[8].estado.ToString(),
                            listaGruas[9].proximaLlegadaReparación.ToString() + "-" + listaGruas[9].estado.ToString(),
                            listaGruas[10].proximaLlegadaReparación.ToString() + "-" + listaGruas[10].estado.ToString(),
                            listaGruas[11].proximaLlegadaReparación.ToString() + "-" + listaGruas[11].estado.ToString(),
                            listaGruas[12].proximaLlegadaReparación.ToString() + "-" + listaGruas[12].estado.ToString(),
                            listaGruas[13].proximaLlegadaReparación.ToString() + "-" + listaGruas[13].estado.ToString(),
                            listaGruas[14].proximaLlegadaReparación.ToString() + "-" + listaGruas[14].estado.ToString(),
                            listaGruas[15].proximaLlegadaReparación.ToString() + "-" + listaGruas[15].estado.ToString(),
                            listaGruas[16].proximaLlegadaReparación.ToString() + "-" + listaGruas[16].estado.ToString(),
                            listaGruas[17].proximaLlegadaReparación.ToString() + "-" + listaGruas[17].estado.ToString(),
                            listaGruas[18].proximaLlegadaReparación.ToString() + "-" + listaGruas[18].estado.ToString(),
                            listaGruas[19].proximaLlegadaReparación.ToString() + "-" + listaGruas[19].estado.ToString(),
                            listaGruas[20].proximaLlegadaReparación.ToString() + "-" + listaGruas[20].estado.ToString(),
                            listaGruas[21].proximaLlegadaReparación.ToString() + "-" + listaGruas[21].estado.ToString(),
                            listaGruas[22].proximaLlegadaReparación.ToString() + "-" + listaGruas[22].estado.ToString(),
                            listaGruas[23].proximaLlegadaReparación.ToString() + "-" + listaGruas[23].estado.ToString(),
                            listaGruas[24].proximaLlegadaReparación.ToString() + "-" + listaGruas[24].estado.ToString(),
                            listaGruas[25].proximaLlegadaReparación.ToString() + "-" + listaGruas[25].estado.ToString(),
                            listaGruas[26].proximaLlegadaReparación.ToString() + "-" + listaGruas[26].estado.ToString(),
                            listaGruas[27].proximaLlegadaReparación.ToString() + "-" + listaGruas[27].estado.ToString(),
                            listaGruas[28].proximaLlegadaReparación.ToString() + "-" + listaGruas[28].estado.ToString(),
                            listaGruas[29].proximaLlegadaReparación.ToString() + "-" + listaGruas[29].estado.ToString(),
                            listaGruas[30].proximaLlegadaReparación.ToString() + "-" + listaGruas[30].estado.ToString(),
                            listaGruas[31].proximaLlegadaReparación.ToString() + "-" + listaGruas[31].estado.ToString(),
                            listaGruas[32].proximaLlegadaReparación.ToString() + "-" + listaGruas[32].estado.ToString(),
                            listaGruas[33].proximaLlegadaReparación.ToString() + "-" + listaGruas[33].estado.ToString(),
                            listaGruas[34].proximaLlegadaReparación.ToString() + "-" + listaGruas[34].estado.ToString(),
                            listaGruas[35].proximaLlegadaReparación.ToString() + "-" + listaGruas[35].estado.ToString(),
                            listaGruas[36].proximaLlegadaReparación.ToString() + "-" + listaGruas[36].estado.ToString(),
                            listaGruas[37].proximaLlegadaReparación.ToString() + "-" + listaGruas[37].estado.ToString(),
                            listaGruas[38].proximaLlegadaReparación.ToString() + "-" + listaGruas[38].estado.ToString(),
                            listaGruas[39].proximaLlegadaReparación.ToString() + "-" + listaGruas[39].estado.ToString(),
                            listaGruas[40].proximaLlegadaReparación.ToString() + "-" + listaGruas[40].estado.ToString(),
                            listaGruas[41].proximaLlegadaReparación.ToString() + "-" + listaGruas[41].estado.ToString(),
                            listaGruas[42].proximaLlegadaReparación.ToString() + "-" + listaGruas[42].estado.ToString(),
                            listaGruas[43].proximaLlegadaReparación.ToString() + "-" + listaGruas[43].estado.ToString(),
                            listaGruas[44].proximaLlegadaReparación.ToString() + "-" + listaGruas[44].estado.ToString(),
                            listaGruas[45].proximaLlegadaReparación.ToString() + "-" + listaGruas[45].estado.ToString(),
                            listaGruas[46].proximaLlegadaReparación.ToString() + "-" + listaGruas[46].estado.ToString(),
                            listaGruas[47].proximaLlegadaReparación.ToString() + "-" + listaGruas[47].estado.ToString(),
                            listaGruas[48].proximaLlegadaReparación.ToString() + "-" + listaGruas[48].estado.ToString(),
                            listaGruas[49].proximaLlegadaReparación.ToString() + "-" + listaGruas[49].estado.ToString(),
                            listaGruas[50].proximaLlegadaReparación.ToString() + "-" + listaGruas[50].estado.ToString(),
                            listaGruas[51].proximaLlegadaReparación.ToString() + "-" + listaGruas[51].estado.ToString(),
                            listaGruas[52].proximaLlegadaReparación.ToString() + "-" + listaGruas[52].estado.ToString(),
                            listaGruas[53].proximaLlegadaReparación.ToString() + "-" + listaGruas[53].estado.ToString(),
                            listaGruas[54].proximaLlegadaReparación.ToString() + "-" + listaGruas[54].estado.ToString(),
                            listaGruas[55].proximaLlegadaReparación.ToString() + "-" + listaGruas[55].estado.ToString(),
                            listaGruas[56].proximaLlegadaReparación.ToString() + "-" + listaGruas[56].estado.ToString(),
                            listaGruas[57].proximaLlegadaReparación.ToString() + "-" + listaGruas[57].estado.ToString(),
                            listaGruas[58].proximaLlegadaReparación.ToString() + "-" + listaGruas[58].estado.ToString(),
                            listaGruas[59].proximaLlegadaReparación.ToString() + "-" + listaGruas[59].estado.ToString(),
                            listaGruas[60].proximaLlegadaReparación.ToString() + "-" + listaGruas[60].estado.ToString(),
                            listaGruas[61].proximaLlegadaReparación.ToString() + "-" + listaGruas[61].estado.ToString(),
                            listaGruas[62].proximaLlegadaReparación.ToString() + "-" + listaGruas[62].estado.ToString(),
                            listaGruas[63].proximaLlegadaReparación.ToString() + "-" + listaGruas[63].estado.ToString(),
                            listaGruas[64].proximaLlegadaReparación.ToString() + "-" + listaGruas[64].estado.ToString(),
                            listaGruas[65].proximaLlegadaReparación.ToString() + "-" + listaGruas[65].estado.ToString(),
                            listaGruas[66].proximaLlegadaReparación.ToString() + "-" + listaGruas[66].estado.ToString(),
                            listaGruas[67].proximaLlegadaReparación.ToString() + "-" + listaGruas[67].estado.ToString(),
                            listaGruas[68].proximaLlegadaReparación.ToString() + "-" + listaGruas[68].estado.ToString(),
                            listaGruas[69].proximaLlegadaReparación.ToString() + "-" + listaGruas[69].estado.ToString(),
                            listaGruas[70].proximaLlegadaReparación.ToString() + "-" + listaGruas[70].estado.ToString(),
                            listaGruas[71].proximaLlegadaReparación.ToString() + "-" + listaGruas[71].estado.ToString(),
                            listaGruas[72].proximaLlegadaReparación.ToString() + "-" + listaGruas[72].estado.ToString(),
                            listaGruas[73].proximaLlegadaReparación.ToString() + "-" + listaGruas[73].estado.ToString(),
                            listaGruas[74].proximaLlegadaReparación.ToString() + "-" + listaGruas[74].estado.ToString(),
                            listaGruas[75].proximaLlegadaReparación.ToString() + "-" + listaGruas[75].estado.ToString(),
                            listaGruas[76].proximaLlegadaReparación.ToString() + "-" + listaGruas[76].estado.ToString(),
                            listaGruas[77].proximaLlegadaReparación.ToString() + "-" + listaGruas[77].estado.ToString(),
                            listaGruas[78].proximaLlegadaReparación.ToString() + "-" + listaGruas[78].estado.ToString(),
                            listaGruas[79].proximaLlegadaReparación.ToString() + "-" + listaGruas[79].estado.ToString(),
                            listaGruas[80].proximaLlegadaReparación.ToString() + "-" + listaGruas[80].estado.ToString(),
                            listaGruas[81].proximaLlegadaReparación.ToString() + "-" + listaGruas[81].estado.ToString(),
                            listaGruas[82].proximaLlegadaReparación.ToString() + "-" + listaGruas[82].estado.ToString(),
                            listaGruas[83].proximaLlegadaReparación.ToString() + "-" + listaGruas[83].estado.ToString(),
                            listaGruas[84].proximaLlegadaReparación.ToString() + "-" + listaGruas[84].estado.ToString(),
                            listaGruas[85].proximaLlegadaReparación.ToString() + "-" + listaGruas[85].estado.ToString(),
                            listaGruas[86].proximaLlegadaReparación.ToString() + "-" + listaGruas[86].estado.ToString(),
                            listaGruas[87].proximaLlegadaReparación.ToString() + "-" + listaGruas[87].estado.ToString(),
                            listaGruas[88].proximaLlegadaReparación.ToString() + "-" + listaGruas[88].estado.ToString(),
                            listaGruas[89].proximaLlegadaReparación.ToString() + "-" + listaGruas[89].estado.ToString(),
                            listaGruas[90].proximaLlegadaReparación.ToString() + "-" + listaGruas[90].estado.ToString(),
                            listaGruas[91].proximaLlegadaReparación.ToString() + "-" + listaGruas[91].estado.ToString(),
                            listaGruas[92].proximaLlegadaReparación.ToString() + "-" + listaGruas[92].estado.ToString(),
                            listaGruas[93].proximaLlegadaReparación.ToString() + "-" + listaGruas[93].estado.ToString(),
                            listaGruas[94].proximaLlegadaReparación.ToString() + "-" + listaGruas[94].estado.ToString(),
                            listaGruas[95].proximaLlegadaReparación.ToString() + "-" + listaGruas[95].estado.ToString(),
                            listaGruas[96].proximaLlegadaReparación.ToString() + "-" + listaGruas[96].estado.ToString(),
                            listaGruas[97].proximaLlegadaReparación.ToString() + "-" + listaGruas[97].estado.ToString(),
                            listaGruas[98].proximaLlegadaReparación.ToString() + "-" + listaGruas[98].estado.ToString(),
                            listaGruas[99].proximaLlegadaReparación.ToString() + "-" + listaGruas[99].estado.ToString(),
                            listaGruas[100].proximaLlegadaReparación.ToString() + "-" + listaGruas[100].estado.ToString(),
                            listaGruas[101].proximaLlegadaReparación.ToString() + "-" + listaGruas[101].estado.ToString(),
                            listaGruas[102].proximaLlegadaReparación.ToString() + "-" + listaGruas[102].estado.ToString(),
                            listaGruas[103].proximaLlegadaReparación.ToString() + "-" + listaGruas[103].estado.ToString(),
                            listaGruas[104].proximaLlegadaReparación.ToString() + "-" + listaGruas[104].estado.ToString(),
                            listaGruas[105].proximaLlegadaReparación.ToString() + "-" + listaGruas[105].estado.ToString(),
                            listaGruas[106].proximaLlegadaReparación.ToString() + "-" + listaGruas[106].estado.ToString(),
                            listaGruas[107].proximaLlegadaReparación.ToString() + "-" + listaGruas[107].estado.ToString(),
                            listaGruas[108].proximaLlegadaReparación.ToString() + "-" + listaGruas[108].estado.ToString(),
                            listaGruas[109].proximaLlegadaReparación.ToString() + "-" + listaGruas[109].estado.ToString(),
                            listaGruas[110].proximaLlegadaReparación.ToString() + "-" + listaGruas[110].estado.ToString(),
                            listaGruas[111].proximaLlegadaReparación.ToString() + "-" + listaGruas[111].estado.ToString(),
                            listaGruas[112].proximaLlegadaReparación.ToString() + "-" + listaGruas[112].estado.ToString(),
                            listaGruas[113].proximaLlegadaReparación.ToString() + "-" + listaGruas[113].estado.ToString(),
                            listaGruas[114].proximaLlegadaReparación.ToString() + "-" + listaGruas[114].estado.ToString(),
                            listaGruas[115].proximaLlegadaReparación.ToString() + "-" + listaGruas[115].estado.ToString(),
                            listaGruas[116].proximaLlegadaReparación.ToString() + "-" + listaGruas[116].estado.ToString(),
                            listaGruas[117].proximaLlegadaReparación.ToString() + "-" + listaGruas[117].estado.ToString(),
                            listaGruas[118].proximaLlegadaReparación.ToString() + "-" + listaGruas[118].estado.ToString(),
                            listaGruas[119].proximaLlegadaReparación.ToString() + "-" + listaGruas[119].estado.ToString(),

                //listaClientes[0].Estado == "noExiste" ? " " : listaClientes[0].Estado.ToString() + "(" +listaClientes[0].cantidadCliente.ToString()+ ")" ,
                //listaClientes[1].Estado == "noExiste" ? " " : listaClientes[1].Estado.ToString() + "(" +listaClientes[1].cantidadCliente.ToString()+ ")" ,
                //listaClientes[2].Estado == "noExiste" ? " " : listaClientes[2].Estado.ToString() + "(" +listaClientes[2].cantidadCliente.ToString()+ ")" ,
                //listaClientes[3].Estado == "noExiste" ? " " : listaClientes[3].Estado.ToString() + "(" +listaClientes[3].cantidadCliente.ToString()+ ")" ,


            };       
            dgvTabla.Rows.Add(fila2);

        }

        //dar posibilidad de ingresar ese 1 y 4, es decir los extremos de la distriubiocn uniforme
        public int calcularTiempoReparacion(double numeroRND1)
        {
            var tiempoReparacion =(int)Math.Truncate(1 + (numeroRND1 * 4));
            return tiempoReparacion;
        }


        private void botonSimular_Click(object sender, EventArgs e)
        {
            var time = DateTime.Now;
            dgvTabla.Visible = false;
            dgvTabla.Rows.Clear();

            var Iteraciones = Convert.ToDouble(txtN.Text);
            var desde = Convert.ToDouble(txtDesde.Text);

            var registro = new Registro();
            registro.evento = "Inicializacion";


            // sacamos antes del for todas las proximas roturas y debemos mostrarlo
            var listaProximasLlgadas = new List<int>();
            var listaGruas = new List<Grua>();
            for (int i = 0; i < 120; i++)
            {
                listaGruas.Add(new Grua());
                //listaProximasLlgadas.Add(0);
            }

            var listaTaller = new List<Taller>();

            for (int i = 0; i < 8; i++)
            {
                var taller = new Taller();
                taller.numeroTaller = i;
                listaTaller.Add(taller);

            }
            var x = 1;



            var primero = false;

            var minimoProximaLlegadaGrua = 0;
            var minimoFinAtencion = 0;

            List<Grua> colaGruasEsperando = new List<Grua>();
            Random random1 = new Random();


            for (var i = 0; i < listaGruas.Count; i++)
            {
                double numeroRND = random1.NextDouble();
                //console.log("rnd aaa :" + random)
                // this.listaGruas[i].numeroGrua = i ;
                listaGruas[i].numeroGrua = i;
                listaGruas[i].RndPrimerRotura = numeroRND;
                listaGruas[i].tiempoProximaRotura = devolverTiempoPrimeraRotura(numeroRND);
                listaGruas[i].proximaLlegadaReparación = registro.reloj + listaGruas[i].tiempoProximaRotura;
                

            }



            mostrarTabla(registro, listaTaller, listaGruas);
            //aca arranca las iteraciones
            for (var j = 0; j < Iteraciones; j++)
            {
                var minimoLLegadaGrua = 99999999;
                //var gruaProximaLlegada = new Grua();
                var gruaProximaLlegada = new Grua(); 
                //List<int> ordenados = listaProximasLlgadas.OrderBy(number => number).ToList();

                for (var i = 0; i < 120; i++)
                {
                    if (minimoLLegadaGrua > listaGruas[i].proximaLlegadaReparación && listaGruas[i].estado == "T")
                    {
                        minimoLLegadaGrua = listaGruas[i].proximaLlegadaReparación;
                        gruaProximaLlegada = listaGruas[i];
                    }
                }

                var minimoFinReparacion = 99999999;
                var ban = false;
                for (var i = 0; i < 8; i++)
                {
                    if (listaTaller[i].estado == "Rep")
                    {
                        if (minimoFinReparacion > listaTaller[i].finReparacion)
                        {
                            minimoFinReparacion = listaTaller[i].finReparacion;
                        }
                        ban = true;
                    }
                }
                



                //pregunto cual es el proximo evento
                if(minimoLLegadaGrua < minimoFinReparacion || ban == false && minimoLLegadaGrua != 99999999)
                {
                    registro.reloj = minimoLLegadaGrua;
                    registro.evento = "Lleg Grua " + (gruaProximaLlegada.numeroGrua + 1).ToString();

                    bool hayDisponibleTaller = hayDisponibilidadTaller(listaTaller);

                    if (hayDisponibleTaller)
                    {
                        //traigo el taller libre
                        var tallerLibre = traerTallerLibre(listaTaller);
                        //cambio el estado del taller y la grua 
                        tallerLibre.Reparando(tallerLibre);
                        // inicio atencion

                        gruaProximaLlegada.InicioReparacion = registro.reloj;
                        //cambio de estado
                        gruaProximaLlegada.Repararndo(gruaProximaLlegada);
                        //asigno la grua al taller
                        tallerLibre.grua = gruaProximaLlegada;

                        double numeroRND1 = random1.NextDouble();
                        //calculo el tiempo de reparacion y fin de reparacion
                        tallerLibre.tiempoReparacion = calcularTiempoReparacion(numeroRND1);
                        tallerLibre.finReparacion = registro.reloj + tallerLibre.tiempoReparacion;
                        //actualizo el taller en la lista
                        listaTaller[tallerLibre.numeroTaller] = tallerLibre;
                    }
                    else
                    {
                        gruaProximaLlegada.InicioReparacion = registro.reloj;
                        colaGruasEsperando.Add(gruaProximaLlegada);
                        gruaProximaLlegada.EsperarEnCola(gruaProximaLlegada);
                        registro.cantidadGruasCola = colaGruasEsperando.Count();
                    }
                }

                //FIN REPARACION
                else
                {

                    var taller =new Taller();
                    for (var i = 0; i < 8; i++)
                    {
                        if (listaTaller[i].estado == "Rep" && listaTaller[i].finReparacion == minimoFinReparacion)
                        {
                            taller = listaTaller[i];                        
                        }
                    }

                    registro.reloj = minimoFinReparacion;
                    registro.evento = "Fin R taller " + (taller.numeroTaller + 1).ToString();
                    
                    //cambiar ese 20 y dejar que lo ingresen por parametro
                    taller.grua.proximaLlegadaReparación = registro.reloj +20;

                    //saco el fin reparacion grua
                    taller.grua.FinReparacion = registro.reloj;


                    var maximo = taller.grua.FinReparacion - taller.grua.InicioReparacion;

                    if(maximo > registro.tiempoMaximoReparacion) { 
                        registro.tiempoMaximoReparacion = maximo;
                    }

                    registro.AcumuladorGruasReparadas += 1;
                    registro.AcumuladorTiemposReparacion += taller.grua.FinReparacion - taller.grua.InicioReparacion;

                    var promedio = ((double)registro.AcumuladorTiemposReparacion / (double)registro.AcumuladorGruasReparadas);
                   
                    registro.PromedioTiempoReparacion = Math.Truncate(promedio * 1000) / 1000;


                    taller.grua.Trabajando(taller.grua);
                    //hace falta actualizar la lista?????
                    listaGruas[taller.grua.numeroGrua] = taller.grua; 

                    if(colaGruasEsperando.Count == 0)
                    {
                        taller.LiberarTaller(taller);
                    }
                    else
                    {
                        var gruaSaleCola = colaGruasEsperando[0];


                        registro.cantidadGruasCola = colaGruasEsperando.Count();
                        taller.grua = gruaSaleCola;

                        //estado a reparar el taller
                        taller.Reparando(taller);
                        taller.grua.Repararndo(taller.grua);

                        //taller.grua.InicioReparacion = registro.reloj; aca no va porque ya ingreso a reparacion,estaba esperando
                        double numeroRND2 = random1.NextDouble();
                        //calculo el tiempo de reparacion y fin de reparacion
                        taller.tiempoReparacion = calcularTiempoReparacion(numeroRND2);
                        taller.finReparacion = registro.reloj + taller.tiempoReparacion;
                        //actualizo el taller en la lista

                        //lo saco de la cola
                        colaGruasEsperando.Remove(colaGruasEsperando[0]);
                    }


                }

                if( j >= desde &&  j <= (desde + 400)  )
                {
                    mostrarTabla(registro, listaTaller, listaGruas);
                    
                }


            }
            var fueraFor = 0;

            mostrarTabla(registro, listaTaller, listaGruas);
            var diferenciaTiempo = DateTime.Now - time;


            label2.Text = diferenciaTiempo.ToString();
            dgvTabla.Visible = true;
        }


    }

}
