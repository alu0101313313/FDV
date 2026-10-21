# Ejercicios 01: Movimiento Rectilíneo
<sup> José Javier Ramos Carballo, [alu0101313313](https://github.com/alu0101313313)


## Indice

1. [Introducción](#1-introducción)
2. [Tareas a Realizar](#2-tareas-a-realizar)
3. [Desarrollo](#3-desarrollo)
4. [Conclusiones](#4-conclusiones)
5. [Bibliografía](#5-bibliografía)


## 1. Introducción
En esta práctica de la asignatura [Fundamentos del Desarrollo de Videojuegos](https://campusvirtual.ull.es/2627/doctoradoyposgrado/course/view.php?id=2627110295), nos encargaremos de realizar una serie de ejercicios relativos a como funciona el movimiento rectilineo en los obejetos dentro del motor Unity

## 2. Tareas a Realizar

  1. [ ] Realizar los diferentes ejercicios marcados en la [hoja de ejercicios](https://docs.google.com/document/d/18_EWkMjJ2FBR3tfW_vu2qM16d7farPdCy09AC_LEeog/edit?tab=t.0)

## 3. Desarrollo

Para comenzar, realizaremos el primer ejericio que nos indica que debemos realizar un desplazamiento de un objeto 3D con la función **_Translate()_**.

![cilindro_con_script_ej1](./Assets/media/cilindro_con_script_ej1.png)

Tras vincular el script con el cilindro, y insertando el siguiente codigo:

```C#

	using UnityEngine;

	public class ejercicio1 : MonoBehaviour
	{
		private Vector3 GoalPosition = new Vector3(22, 1, -14);
		
		void Start()
		{
			this.transform.Translate(GoalPosition);
		}

		void Update()
		{
				
		}
	}

```

> [!IMPORTANT]
> Fijese lo importante que es observar tanto la posición antes de ejecutar, y lo que se propone en _GoalPosition_.

Al ejecutar, podemos observar el siguiente comportamiento:

![cilindro_ej1_desplazado](./Assets/media/cilindro_ej1_desplazado.png)

Es importante ver que el cilindro no se ha desplazado directamente a la posición que hemos indiciado en _GoalPosition_, sino que _this.transform.Translate(GoalPosition)_, ha sumado la posición inicial del cilindro mas la indicada, por que nos da como posición final, la posición indicada en la imagen.

Todo este comportamiento se indica en el enunciado, asi que lo que tenemos que comprobar son los diferentes apartados:

 - [ ] Añadir this.transform.Translate(goal); al Update e ir multiplicando goal = goal * 0.5f; de esta forma darás saltos más pequeños cada vez. ¿Qué sucede si pones la instrucción  goal = goal * 0.5f; en el Start?. Qué sucede si en el Update incluyes goal = goal * 2.0f;

Al realizar estos cambios, podemos apreciar las siguientes diferencias:

 - Cuando añadimos la funcion _Translate()_ en el update, y actualizamos su valor se actualiza en cada frame, pero como en cada uno su alcance se divide en la mitad, este se mueve cada vez mas lento hasta que se queda quieto.

 - En este caso, lo que ocurre es que al recolocar la actualización en el start, se mantiene que solo se divide una vez la posición de conclusión, pero se sigue actualizando la posición cada frame, este movimiento se mantiene constante, provocando que con el siguiente codigo se resuelva de la siguiente manera:

 ```C#

	using UnityEngine;

	public class ejercicio1 : MonoBehaviour
	{
		private Vector3 GoalPosition = new Vector3(22, 1, -14);
		
		void Start()
		{
			// Actualización movimiento
			GoalPosition = GoalPosition * 0.5f;
		}

		void Update()
		{
			this.transform.Translate(GoalPosition);
		}
	}

 ```

 ![ejecuccion_1b](./Assets/media/ejecucion_1b.gif)

 - Luego de volver a colocar la actualización de la posición en el _Update()_, junto a la función _Translate()_ cambiar la actualización para duplicar la posición final, pasa lo contrario al primer caso, donde este se mueve exponencialmente hasta llegar al limite del mapa.



 


## 4. Conclusiones
Gracias a esta práctica, podemos tener unas nociones esenciales de como tener trabajar el movimiento rectilineo.

## 5. Bibliografía
1. **Enunciado de la práctica:** [https://campusvirtual.ull.es/2627/doctoradoyposgrado/mod/assign/view.php?id=23525](https://campusvirtual.ull.es/2627/doctoradoyposgrado/mod/assign/view.php?id=23525)

2. **Guión de la práctica:** [https://docs.google.com/document/d/18_EWkMjJ2FBR3tfW_vu2qM16d7farPdCy09AC_LEeog/edit?tab=t.0](https://docs.google.com/document/d/18_EWkMjJ2FBR3tfW_vu2qM16d7farPdCy09AC_LEeog/edit?tab=t.0)

