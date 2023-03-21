using System.Collections.Generic;
Dictionary <string, double> recaudacionCursos = new Dictionary<string, double>();
int alumnosTotal = 0, seleccion = IngresarInt("Ingresá 1) si querés agregar datos del curso o 2) si querés conocer los datos actuales");
while(seleccion != 0){
    
    switch(seleccion)
    {
        case 1:
        DatosCursos(recaudacionCursos, ref alumnosTotal);
            break;
        case 2:
        ConocerDatos(recaudacionCursos, alumnosTotal);
            break;
    }  
    seleccion = IngresarInt("Ingresá 1) si querés agregar datos del curso o 2) si querés conocer los datos actuales");
}

static string IngresarString(string msg)
{
	Console.WriteLine(msg);
	return Console.ReadLine();
}
static int IngresarInt(string msg)
{
	Console.WriteLine(msg);
	return int.Parse(Console.ReadLine());
}
static double IngresarDouble(string msg)
{
	Console.WriteLine(msg);
	return double.Parse(Console.ReadLine());
}

void DatosCursos(Dictionary <string, double> recaudacionCursos, ref int alumnosTotal)
{
    string cursoIngresado = "";
    int cantAlumnos = 0;
    double cantTotalPlataCurso = 0, plataIngresada;
    cursoIngresado = IngresarString("Ingresá el curso");
    while(cursoIngresado != "FIN")
    {
        cantAlumnos = IngresarInt("Ingresá la cantidad de alumnos");
        alumnosTotal += cantAlumnos;
        for(int i = 0; i< cantAlumnos; i++)
        {
            plataIngresada = IngresarDouble("Ingresá la plata que aporta el estudiante");
            cantTotalPlataCurso += plataIngresada;
        }
        recaudacionCursos.Add(cursoIngresado, cantTotalPlataCurso);
        cursoIngresado = IngresarString("Ingresá el curso");
    }
}
void ConocerDatos(Dictionary <string, double> recaudacionCursos, int alumnosTotal)
{
    string cursoMayorPlata = "";
    double mayor = 0, totalPlata = 0;
    foreach(string IndividualCurso in recaudacionCursos.Keys)
    {
        if(recaudacionCursos[IndividualCurso] > mayor)
        {
            mayor = recaudacionCursos[IndividualCurso];
            cursoMayorPlata = IndividualCurso;
        }
        totalPlata += recaudacionCursos[IndividualCurso];
    }
    if(totalPlata == 0) Console.WriteLine("No hay datos previamente cargados");
    else{Console.WriteLine("El curso con más plata aportada es " + cursoMayorPlata);
    Console.WriteLine("El promedio de la plata aportada opr todos los cursos es  " + totalPlata/alumnosTotal + "%");
    Console.WriteLine("La recaudación total de todos los cursos es de " + totalPlata);
    Console.WriteLine("La cantidad de cursos que participan es " + recaudacionCursos.Count());}
}