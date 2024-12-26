// See https://aka.ms/new-console-template for more information
using agl_algoritmos;


double ponto_de_passagem_lat = -22.864134;
double ponto_de_passagem_lon = -48.444508;
double ponto_marcado_lat     = -22.864100;
double ponto_marcado_lon     = -48.444500;

double margem_de_erro_em_metros = 20;
bool   esta_dentro           = Coordenadas.EstaDentroDaCoordenada(ponto_de_passagem_lat, ponto_de_passagem_lon, ponto_marcado_lat, ponto_marcado_lon, margem_de_erro_em_metros);
Console.WriteLine("Margem de 20 metros");
Console.WriteLine(esta_dentro ? "O ponto está dentro do círculo." : "O ponto está fora do círculo.");
Console.WriteLine(" ");

margem_de_erro_em_metros = 15;
esta_dentro = Coordenadas.EstaDentroDaCoordenada(ponto_de_passagem_lat, ponto_de_passagem_lon, ponto_marcado_lat, ponto_marcado_lon, margem_de_erro_em_metros);
Console.WriteLine("Margem de 15 metros");
Console.WriteLine(esta_dentro ? "O ponto está dentro do círculo." : "O ponto está fora do círculo.");
Console.WriteLine(" ");

margem_de_erro_em_metros = 10;
esta_dentro = Coordenadas.EstaDentroDaCoordenada(ponto_de_passagem_lat, ponto_de_passagem_lon, ponto_marcado_lat, ponto_marcado_lon, margem_de_erro_em_metros);
Console.WriteLine("Margem de 10 metros");
Console.WriteLine(esta_dentro ? "O ponto está dentro do círculo." : "O ponto está fora do círculo.");
Console.WriteLine(" ");

margem_de_erro_em_metros = 5;
esta_dentro = Coordenadas.EstaDentroDaCoordenada(ponto_de_passagem_lat, ponto_de_passagem_lon, ponto_marcado_lat, ponto_marcado_lon, margem_de_erro_em_metros);
Console.WriteLine("Margem de 5 metros");
Console.WriteLine(esta_dentro ? "O ponto está dentro do círculo." : "O ponto está fora do círculo.");
Console.WriteLine(" ");

margem_de_erro_em_metros = 4;
esta_dentro = Coordenadas.EstaDentroDaCoordenada(ponto_de_passagem_lat, ponto_de_passagem_lon, ponto_marcado_lat, ponto_marcado_lon, margem_de_erro_em_metros);
Console.WriteLine("Margem de 4 metros");
Console.WriteLine(esta_dentro ? "O ponto está dentro do círculo." : "O ponto está fora do círculo.");
Console.WriteLine(" ");

margem_de_erro_em_metros = 3;
esta_dentro = Coordenadas.EstaDentroDaCoordenada(ponto_de_passagem_lat, ponto_de_passagem_lon, ponto_marcado_lat, ponto_marcado_lon, margem_de_erro_em_metros);
Console.WriteLine("Margem de 3 metros");
Console.WriteLine(esta_dentro ? "O ponto está dentro do círculo." : "O ponto está fora do círculo.");
Console.WriteLine(" ");

margem_de_erro_em_metros = 2;
esta_dentro = Coordenadas.EstaDentroDaCoordenada(ponto_de_passagem_lat, ponto_de_passagem_lon, ponto_marcado_lat, ponto_marcado_lon, margem_de_erro_em_metros);
Console.WriteLine("Margem de 2 metros");
Console.WriteLine(esta_dentro ? "O ponto está dentro do círculo." : "O ponto está fora do círculo.");
Console.WriteLine(" ");