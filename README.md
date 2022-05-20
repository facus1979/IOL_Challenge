# IOL CodingChallenge
 Resolucion del Coding Challenge planteado.
 Se busco refactorizar bajo los principios de **SOLID**, intentando escribir un mejor codigo, buscando mantener una **alta cohesion y un bajo nivel de acoplamiento**.
 Se desacoplaron las Formas Geometricas del Reporte, de manera que cada una es independiente de la otra, un Reporte no tiene por que conocer de Formas Geometricas y viceversa.  
 Tambien se separaron las traducciones de las Formas Geometricas y el Reporte, las traducciones son administradas por el framework, mediante el cambio de la configuracion regional (en el scope de generacion del reporte), haciendo uso de diccionarios de resources (se encuentran en un proyecto aparte).  
 Por ultimo las Formas Geometricas se modelaron en base a una clase abstracta que les da la estructura general, para que luego cada clase concreta redefina sus metodos particulares.
 
 ### Proyectos contenidos en la Solucion
 Todos los proyectos estan realizados en .NET Framework 4.5.2

 **App.CodingChallenge**: 
 Proyecto Winform para prueba de Librerias e impresion de reporte (visualizacion de html sobre webbrowser integrado).
 
 **Library.CodingChallenge**:
 Proyecto donde se realizo la refactorizacion del codigo original.
 
 **Test.CodingChallenge**:
 Proyecto de Test unitarios, divididos en 2 Fixtures. Uno para las librerias, testeando idiomas y calculos (Superficie,Perimetro). 
 Y otro para el Reporte y los resultados esperados segun idioma y distintas formas geometricas.
 
 **Translation.CodingChallenge**:
 Proyecto que contiene los archivos de resources regionalizados por idioma (ES y EN), los cuales son utilizados a modo de diccionario para las traducciones..
