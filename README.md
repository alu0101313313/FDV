# Practica 01: Herramienta Git LFS
<sup> José Javier Ramos Carballo, [alu0101313313](https://github.com/alu0101313313)


## Indice

1. [Introducción](#1-introducción)
2. [Tareas a Realizar](#2-tareas-a-realizar)
3. [Desarrollo](#3-desarrollo)
4. [Conclusiones](#4-conclusiones)
5. [Bibliografía](#5-bibliografía)


## 1. Introducción
En esta práctica de la asignatura [Fundamentos del Desarrollo de Videojuegos](https://campusvirtual.ull.es/2627/doctoradoyposgrado/course/view.php?id=2627110295), nos encargaremos de realizar una serie de ejercicios relativos al funcionamiento de las fisicas en un proyecto 3D en Unity.

## 2. Tareas a Realizar

  - [ ] Ejercicio 1: Experimentar con diferentes configuraciones de los components Rigidbody y Collider y explicar los resultados obtenidos en base a lo explicado en clase.
  - [ ] Ejercicio 2: Crea un controlador con las teclas flecha arriba-abajo, derecha-izquierda que controle al cilindro con físicas
  - [ ] Ejercicio 3: Crea varios cubos o esferas con Rigidbody dinámico. Muestra por consola el nombre del objeto con el que colisiona, y cámbiale su color al colisionar.
  - [ ] Ejercicio 4: En la escena debe haber 3. Un cubo y un cilindro cinemáticos, una esfera con collider y Rigidbody. Marcar el cilindro como objetivo a alcanzar por la esfera. El cubo debe hacer de obstáculo entre ambos. Implementar un script que haga que la esfera se dirija al cilindro, cuando la esfera alcance el cubo, este debe cambiar su material y el cubo avanzar hacia adelante.

## 3. Desarrollo

Comenzamos colocando la escena tal cual como se nos pide en el guión de la práctica, ademas de añadir materiales a los diferentes elementos de la escena para su mejor identificación visual durante la realización de los ejercicios.

![colocacion_por_defecto](./Assets/Media/colocacion_por_defecto.png)

**_Ejercicio 1_**: Con la colocación principal, realiza las siguientes situaciones:

 1. Plano y Esfera con Collider, Cubo con Rigidbody

 ![situacion_1.1](./Assets/Media/situacion_1.1.png)

 En este caso, tanto el plano, la esfera y cubo contiene su respectivo _Collider_, no obstante, lo que decidi fue probar a añadirle el _Rigidbody_ al Cubo y desactivar el _Box Collider_, esto lo que hace es que el cubo tiene fisicas, y al ejecutar vemos como al no chocar con el collider del plano, este cubo cae infinitamente al vacío.

 Se puede solucionar si se añade que la opción de _IsKinematic_, lo que permite restringir que reciba empujes, gravedad u otras fuerzas que le puedan hacer interactuar.

 2. 

## 4. Conclusiones
Gracias a esta práctica, podemos tener unas nociones esenciales de como funcionan los fundamentos de las fisicas en un proyecto de Unity.

## 5. Bibliografía
1. **Enunciado de la práctica:** [https://campusvirtual.ull.es/2627/doctoradoyposgrado/mod/assign/view.php?id=28155](https://campusvirtual.ull.es/2627/doctoradoyposgrado/mod/assign/view.php?id=28155)

2. **Guión de la práctica:** [https://docs.google.com/document/d/1lRqAT_1zM7fW50KubI1h8SxPrNA5vKGVkdX6U0nJbBU/edit?tab=t.0](https://docs.google.com/document/d/1lRqAT_1zM7fW50KubI1h8SxPrNA5vKGVkdX6U0nJbBU/edit?tab=t.0)