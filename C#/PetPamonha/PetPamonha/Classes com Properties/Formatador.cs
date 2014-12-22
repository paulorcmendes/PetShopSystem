using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetPamonha.Classes_com_Properties
{
    class Formatador
    {
        public String calcularTermino(String data, String duracao){
            int dia, mes, ano, h, min, seg,hD,minD,segD;
            dia = Convert.ToInt32(data.Substring(0, 2));
            mes = Convert.ToInt32(data.Substring(3, 2));
            ano = Convert.ToInt32(data.Substring(6, 4));
            h = Convert.ToInt32(data.Substring(11, 2));
            min = Convert.ToInt32(data.Substring(14, 2));
            seg = Convert.ToInt32(data.Substring(17, 2));
            
            hD = Convert.ToInt32(duracao.Substring(0,2));
            minD = Convert.ToInt32(duracao.Substring(3, 2));
            segD = Convert.ToInt32(duracao.Substring(6, 2));

            DateTime d = new DateTime(ano,mes,dia,h,min,seg);
            TimeSpan t = new TimeSpan(hD,minD,segD);
            d= d.Add(t);
           
            return d.ToString();
        }
        public String formatarData(String data)
        {
            if (data.ElementAt(2).Equals('/'))
            {
                String dia, mes, ano;
                dia = data.Substring(0, 2);
                mes = data.Substring(3, 2);
                ano = data.Substring(6, 4);
                String dataFormt = ano + "/" + mes + "/" + dia;
                String dataN = dataFormt;
                return dataN;
            }
            else
            {
                String dia, mes, ano;
                ano = data.Substring(0, 4);
                mes = data.Substring(5, 2);
                dia = data.Substring(8, 2);
                String dataFormt = dia + "/" + mes + "/" + ano;
                String dataN = dataFormt;
                return dataN;
            }
        }
        public String removerHora(String data)
        {
            String dia, mes, ano;
            dia = data.Substring(0, 2);
            mes = data.Substring(3, 2);
            ano = data.Substring(6, 4);
            String dataFormt = dia + "/" + mes + "/" + ano;
            String dataN = dataFormt;
            return dataN;
        }
        public String formatarDataHora(String dataHora)
        {
            if (dataHora.ElementAt(2).Equals('/'))
            {
                String dia, mes, ano,h,min,seg;
                dia = dataHora.Substring(0, 2);
                mes = dataHora.Substring(3, 2);
                ano = dataHora.Substring(6, 4);
                h = dataHora.Substring(11,2);
                min = dataHora.Substring(14,2);
                seg = dataHora.Substring(17,2);
                String dataFormt = ano + "/" + mes + "/"+dia+" "+h+":"+min+":"+seg;
                String dataN = dataFormt;
                return dataN;
            }
            else
            {
                String dia, mes, ano, h, min, seg;
                ano = dataHora.Substring(0, 4);
                mes = dataHora.Substring(5, 2);
                dia = dataHora.Substring(8, 2);
                h = dataHora.Substring(11, 2);
                min = dataHora.Substring(14, 2);
                seg = dataHora.Substring(17, 2);
                String dataFormt = dia + "/" + mes + "/" + ano + " " + h + ":" + min + ":" + seg;
                String dataN = dataFormt;
                return dataN;
            }
        }
    }
}
