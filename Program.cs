

Console.Write("Digite quantos o tempo (s) decorrido entre o raio e o trovão: ");
double tempo = Convert.ToDouble(Console.ReadLine());

double VelocidadeSom = RaioETrovao(340.29);
Console.WriteLine($"a distancia {VelocidadeSom:N5}");

double RaioETrovao(double VelocidadeSom)
{
    double distancia = VelocidadeSom * tempo / 1000;
    return distancia;
}