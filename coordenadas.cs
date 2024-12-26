using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agl_algoritmos
{
    internal class Coordenadas
    {
        // raio médio do planeta, em metros:
        const double RAIO_DO_PLANETA = 6371000;

        public static bool EstaDentroDaCoordenada(double ponto_de_passagem_lat, double ponto_de_passagem_lon, double ponto_marcado_lat, double ponto_marcado_lon, double margem_de_erro_em_metros)
        {

            // Converter graus para radianos:
            double rad(double graus) => graus * Math.PI / 180;

            // Converter as coordenadas para radianos:
            double ponto_de_passagem_lat_rad = rad(ponto_de_passagem_lat);
            double ponto_de_passagem_lon_rad = rad(ponto_de_passagem_lon);
            double ponto_marcado_lat_rad     = rad(ponto_marcado_lat - ponto_de_passagem_lat);
            double ponto_marcado_lon_rad     = rad(ponto_marcado_lon - ponto_de_passagem_lon);

            // Fórmula de Haversine:
            double a = Math.Sin(ponto_marcado_lat_rad / 2) * Math.Sin(ponto_marcado_lat_rad / 2) +
                       Math.Cos(ponto_de_passagem_lat_rad) * Math.Cos(ponto_de_passagem_lon_rad) *
                       Math.Sin(ponto_marcado_lon_rad / 2) * Math.Sin(ponto_marcado_lon_rad / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double d = RAIO_DO_PLANETA * c; // Distância em metros

            // Verificar se está dentro do raio
            return d <= margem_de_erro_em_metros;
        }
    }
}

