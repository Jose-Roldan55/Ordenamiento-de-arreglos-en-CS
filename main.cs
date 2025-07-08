//Paola Ramirez Flores, Jose Arturo Tulian Roldan, Ariadna Resendiz Flores
using System;

class Program {
  public static void Main (string[] args){
    int longitud,num,respuesta3,buscarnumero,nuevonumero;       
    string respuesta,respuesta2,opcion;
    Console.WriteLine("~~~~~~~~~~~~~~~~BIENVENIDO AL ORDENADOR DE ARREGLOS~~~~~~~~~~~~");
    Console.WriteLine("---------------------------------------------------------------"); 
    do{
    Console.WriteLine("Solo acepto entre 2 y 20 elementos");
    Console.Write("\n¿De cuantos elementos sera tu arreglo?");
    longitud=int.Parse(Console.ReadLine()); //inicializacion de valiable
    while(longitud<2||longitud>20){ //validacion de datos dentro del rango permitido (15, 19)
      Console.WriteLine("Tu numero de elementos no es valido");
      Console.Write("\n¿De cuantos elementos sera tu arreglo? ");
      longitud=int.Parse(Console.ReadLine());
    }
    int[] arr=new int[longitud]; //declaracion, validacion e inicializacion de arreglo (20, 37)
    Console.WriteLine("\nComienza a llenar tu arreglo");
  for(int el=0;el<longitud;){
      Console.Write("Ingresa "+(el+1)+": ");
      num=int.Parse(Console.ReadLine());
     for(int r=0;r<longitud;r++){
       if(arr[r] == num){
        while(arr[r] == num){
        Console.WriteLine("El número ingresado ya existe ");
          Console.WriteLine("Ingresa "+(el+1)+": ");
      num=int.Parse(Console.ReadLine());
        }
       }
      }
        arr[el] = num;
        el++;
     }
    Console.Write("Este es tu arreglo de acuerdo al orden en que lo llenaste: "); //impresion de arreglo (38, 44)
    Console.WriteLine();
    Console.Write("[");
    for(int y=0;y<longitud;y++){
   Console.Write(arr[y]+" ");
    }
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine("¿Deseas ordenar tu arreglo de la forma instantanea s/n?");
    opcion=Console.ReadLine();
      if(opcion=="s" || opcion=="S")
      {
        Array.Sort(arr);
      for(int d=0;d<longitud;d++)
      {
        Console.Write(arr[d]+" ");
      }
      }
      else
      {
    Console.WriteLine("Si deseas hacer una busqueda,una modificacion,eliminar o insertar un elemento en tu arreglo, antes de ordenarlo, por favor sigue con el siguiente menu ");
        Console.WriteLine("Menu");
    Console.WriteLine("1.-Buscar el elemento\n2.-Modificar el arreglo\n3.-Eliminar\n4.-Insertar\n");
    respuesta3=int.Parse(Console.ReadLine());
    switch(respuesta3){
      case 1:
    Console.WriteLine("Escriba el numero del arreglo que deseas buscar");
    buscarnumero=int.Parse(Console.ReadLine());
    foreach(int tem in arr)
    {
      if(tem==buscarnumero)
      {
        Console.WriteLine("Se ha encontrado el resultado");
      }
      else
      {
        Console.WriteLine("No hay resultado de "+buscarnumero);
      }
    }
    break;
        case 2:
    //Modificar
    Console.WriteLine("Buscar el numero en el array");
    buscarnumero=int.Parse(Console.ReadLine());
    Console.WriteLine("Tecle el nuevo numero para agregar al arreglo");
    nuevonumero=int.Parse(Console.ReadLine());
    for(int u=0;u<3;u++){
    if(arr[u]==buscarnumero)
    {
    arr[u]=nuevonumero;
      Console.WriteLine("Los datos han sido modificados");
    }
    }
        Console.Write("[ ");
   foreach(int temp in arr)
  {
    Console.Write(temp+" ");
  }
    Console.Write(" ]\n");
        break;
     case 3:
    //Eliminar[]
        
        break;
      case 4:
      int[] remplazo=new int[longitud+2];
        int o,c,ele,pos;
        do
        {
      Console.WriteLine("Posicion a insertar");
      pos=int.Parse(Console.ReadLine());
        }while(pos<1 || pos>longitud);
//Transladamos datos antes de la posicion
        for(o=1;o<=pos-1;o++)
        {
          remplazo[o]=arr[o];
        }
  //Insertmos elementos
        Console.WriteLine("Ingrese el numero que desea insertar");
        ele=int.Parse(Console.ReadLine());
        remplazo[pos]=ele;
       if(remplazo[pos] == ele){
        while(remplazo[pos] == ele){
        Console.WriteLine("El número ingresado ya existe ");
          Console.Write("Vuelva a ingresar el numero que desea insertar");
       ele=int.Parse(Console.ReadLine());
        }
       }
        remplazo[pos] = ele;
//Transladamos datos despues de la posicion
        for(c=pos;c<=longitud;c++)
        {
          remplazo[c+1]=arr[c];
        }
  //Salida
     Console.WriteLine();
        Console.WriteLine("Nuevo arreglo");
        Console.Write("[ ");
        for(int l=0;l<longitud+1;l++)
        {
         Console.Write(remplazo[l]+" "); 
        }
         Console.Write("]\n");
        break;
      default: 
        Console.WriteLine("dato no valido");
        break;
    }
  }
    Console.WriteLine("\nMenu de ordenadores"); //menu
    Console.WriteLine("1.-Metodo de ordenamiento de burbuja\n2.-Metodo de ordenamiento de insercion\n3.-Metodo de ordenamiento de seleccion");
    Console.WriteLine("¿Que opcion quieres?");
    respuesta=Console.ReadLine();
    switch(respuesta){
      case "1": //inicio de ordenamiento por burbuja (51, 80)
        Console.Clear();
        Console.WriteLine("Hagamoslo por el metodo de burbuja");
   for(int x=0;x<longitud;x++)
     {
     Console.Write("Vuelta "+(x+1)+" "); //impresion de vueltas y como se va ordenando el arreglo
     Console.Write("[ ");
     foreach(int temp in arr)
       Console.Write("{0} ",temp);
       Console.Write("]");
       Console.WriteLine();
      for(int y=x+1;y<longitud;y++)
       {
          int ayuda1;
 //Numero actual es mayor a numero siguiente, si es se cumple haremos un intercambio, esto seria de la forma ascendente
        if(arr[x]>arr[y])
        {
           ayuda1=arr[x];
          arr[x]=arr[y];
          arr[y]=ayuda1;
        }
       }
      }
    Console.WriteLine("Arreglo ordenado por metodo de burbuja"); //impresion de orden final de manera ascendente
    Console.Write("[  ");
    for(int x=0;x<longitud;x++)
    {
      Console.Write(arr[x]+" ");
    }
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine("Ahora el arreglo en forma descendente");
    for(int x=0;x<longitud;x++)
     {
     Console.Write("Vuelta "+(x+1)+" "); //impresion de vueltas y como se va ordenando el arreglo
     Console.Write("[ ");
     foreach(int temp in arr)
       Console.Write("{0} ",temp);
       Console.Write("]");
       Console.WriteLine();
      for(int y=x+1;y<longitud;y++)
       {
          int ayuda11;
 //Numero actual es mayor a numero siguiente, si es se cumple haremos un intercambio, esto seria de la forma ascendente
        if(arr[x]<arr[y])
        {
           ayuda11=arr[x];
          arr[x]=arr[y];
          arr[y]=ayuda11;
        }
       }
      }
     Console.Write("[  ");
    for(int x=0;x<longitud;x++)
       {
      Console.Write(arr[x]+" ");
       }
       Console.Write("]");
      Console.WriteLine();
        break; //fin de ordenamiento por burbuja
      case "2": //inicio de ordenamiento por insercion (81, 101)
        Console.Clear();
        Console.WriteLine("Hagamoslo por el metodo de insercion");
        int s,ayuda2;
//Este arreglo determina la posicion
    for(int i=0;i<longitud;i++)
    { 
      s=i;// se le asigna valor a la variable con la que recorreremos el arreglo
    ayuda2=arr[i];//Una vairable que nos ayude a guardar el valor 
       Console.Write("Vuelta "+(i+1)+" "); //impresion de vueltas y como se va ordenando el arreglo
     Console.Write("[ ");
       foreach(int temp in arr)
       Console.Write("{0} ",temp);
       Console.Write("]");
      Console.WriteLine();
//Se comparara siempre y cuando nuestra posicion sea mayor a 0 y si numero a la izquierda es mayor habra un cambio 
    while(s>0 && (arr[s-1]>ayuda2))
    {
//Intercambiamos y la posicion ira disminuyendo si el numero a la izquierda es mayor al numero actual
      arr[s]=arr[s-1];
      s--;
    }
      arr[s]=ayuda2;
    }
    Console.WriteLine("El arreglo ordenado por metodo de insercion");
    Console.Write("[ "); //impresion de orden final
    for(s=0;s<longitud;s++)
    {
      Console.Write(arr[s]+" ");
    }
    Console.Write("]");
        Console.WriteLine();
        Console.WriteLine("Ahora de forma descendente");
//Este arreglo determina la posicion
    for(int i=0;i<longitud;i++)
    { 
      s=i;// se le asigna valor a la variable con la que recorreremos el arreglo
    ayuda2=arr[i];//Una vairable que nos ayude a guardar el valor 
       Console.Write("Vuelta "+(i+1)+" "); //impresion de vueltas y como se va ordenando el arreglo
     Console.Write("[ ");
       foreach(int temp in arr)
       Console.Write("{0} ",temp);
       Console.Write("]");
      Console.WriteLine();
//Se comparara siempre y cuando nuestra posicion sea mayor a 0 y si numero a la izquierda es mayor habra un cambio 
    while(s>0 && (arr[s-1]<ayuda2))
    {
//Intercambiamos y la posicion ira disminuyendo si el numero a la izquierda es mayor al numero actual
      arr[s]=arr[s-1];
      s--;
    }
      arr[s]=ayuda2;
    }
    Console.Write("[ "); //impresion de orden final
    for(s=0;s<longitud;s++)
      {
      Console.Write(arr[s]+" ");
      }
    Console.Write("]");
        Console.WriteLine();
        break; //fin de ordenamiento por insercion 
      case "3": //inicio de ordenamiento por seleccion (110, 141)
        Console.Clear();
        Console.WriteLine("Hagamoslo por el metodo de seleecion");
        int m,p,ayuda3;
//El -1 representa la cantidad de numeros al buscar el numero menor        
        for(int i=0;i<longitud-1;i++){
          m=arr[i];
          p=i;
          Console.Write("Vuelta "+(i+1)+" "); //impresion de vueltas y como se va ordenando el arreglo
          Console.Write("[ ");
          foreach(int temp in arr)   
          Console.Write("{0} ",temp);
          Console.Write("]");
          Console.WriteLine();
//Desde la posicion 1 buscamos el numero
          for(int h=i+1;h<longitud;h++){
            if(arr[h]<m){
              m=arr[h];
              p=h;
            }
          }
//el intercambio           
          if(p!=i){
            ayuda3=arr[i];
            arr[i]=arr[p];
            arr[p]=ayuda3;
          }
        }
        Console.WriteLine("Arreglo ordenado por metodo de seleccion: "); //impresion de orden final
        Console.Write("[ ");
        for(int z=0;z<longitud;z++){
          Console.Write(arr[z]+" ");
        }
        Console.Write("]");
        Console.WriteLine();
        Console.WriteLine("Ahora de forma descendente");
         for(int i=0;i<longitud-1;i++){
          m=arr[i];
          p=i;
          Console.Write("Vuelta "+(i+1)+" "); //impresion de vueltas y como se va ordenando el arreglo
          Console.Write("[ ");
          foreach(int temp in arr)   
          Console.Write("{0} ",temp);
          Console.Write("]");
          Console.WriteLine();
//Desde la posicion 1 buscamos el numero
          for(int h=i+1;h<longitud;h++){
            if(arr[h]>m){
              m=arr[h];
              p=h;
            }
          }
//el intercambio           
          if(p!=i){
            ayuda3=arr[i];
            arr[i]=arr[p];
            arr[p]=ayuda3;
          }
        }
         Console.Write("[ ");
        for(int z=0;z<longitud;z++){
          Console.Write(arr[z]+" ");
        }
        Console.Write("]");
        Console.WriteLine();
        break; //fin de ordenamiento por
      default: //inicio de lineas de codigo a ejecutar si no se cumple ningun case anterior
        Console.WriteLine("No elegiste ningun metodo");
        break; //fin de default
    }
         Console.WriteLine("\nDeseas hacer otra ordenacion? s/n"); //impresion de pregunta
      respuesta2=Console.ReadLine(); //inicializacion de variable
      if(respuesta2=="n"){ //comparacion para terminar el ciclo si es verdadera
        Console.WriteLine("Gracias por usar el programa"); //mensaje de agradecimiento
      }
    }while(respuesta2=="s"); //comparacion para seguir el ciclo si es verdadera
    }
  }