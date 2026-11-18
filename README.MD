# Ejercicios 03: Sprites 2D
<sup> José Javier Ramos Carballo, [alu0101313313](https://github.com/alu0101313313)


## Indice

1. [Introducción](#1-introducción)
2. [Tareas a Realizar](#2-tareas-a-realizar)
3. [Desarrollo](#3-desarrollo)
4. [Conclusiones](#4-conclusiones)
5. [Bibliografía](#5-bibliografía)


## 1. Introducción
En esta práctica de la asignatura [Fundamentos del Desarrollo de Videojuegos](https://campusvirtual.ull.es/2627/doctoradoyposgrado/course/view.php?id=2627110295), nos encargaremos de realizar una serie de ejercicios relativos a como funciona el sistema de sprites en un proyecto 2D.

## 2. Tareas a Realizar

  1. [ ] Realizar los diferentes ejercicios marcados en la [hoja de ejercicios](https://docs.google.com/document/d/18_EWkMjJ2FBR3tfW_vu2qM16d7farPdCy09AC_LEeog/edit?tab=t.0)

## 3. Desarrollo

1. Agregar el atlas de sprites del personaje a la escena. Configurar el sprite como múltiple y subdividirlo para tener acceso a los sprites para generar las animaciones. Agregar una de las imágenes a la escena. 
![ej1](./Media/ej1.png)


2. Creamos un objeto 2D, arrastrando un conjunto de imágenes que selecciones al objeto añadiremos una animación. Agregar al personaje la animación “Walk Down” . Añadir otra imagen y generarle otra animación.  De esa forma Unity crea un objeto Animation, la primera vez que se crea, también añade un objeto Animator Controller.
![ej2](./Media/Grabación%202026-11-18%20100904.gif)

A partir de este punto, todos los puntos del guión, requeiren de modificar el codigo poco a poco para implementar el movimiento horizontal del personaje, por lo que se colocara el codigo, y se comentara en este informe cada parte de este, lo cual referirá a los que se nos requiere en las siguientes entregas:

```C#

using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.Rendering;

public class CharacterMovement : MonoBehaviour
{
  public float speed = 3f;
  
  private SpriteRenderer spriteRenderer;
  private Animator animator;

  
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {
    spriteRenderer = GetComponent<SpriteRenderer>();
    animator = GetComponent<Animator>();
  }

  // Update is called once per frame
  void Update()
  {
    float horizontalUpdate = Input.GetAxis("Horizontal");
    Vector2 movement = new Vector2(horizontalUpdate, 0);
    transform.Translate(movement * speed * Time.deltaTime);

    if(horizontalUpdate > 0)
    {
      spriteRenderer.flipX = false;
    } 
    else if (horizontalUpdate < 0)
    {
      spriteRenderer.flipX = true;
    }

    animator.SetBool("isWalking", horizontalUpdate != 0);
  }
}

```

Para empezar tenemos lo siguiente:

```C#
public float speed = 3f;

private SpriteRenderer spriteRenderer;
private Animator animator;
```

Un flotante que nos ayudara a indicar la velocidad del movimiento del personaje, la cual la hacemos publica para poder tocar desde el editor de Unity, antes y/o entre la ejecucción.

Mientras que de manera privada, encapsulamos un Animator y un SpriteRenderer, que respectivamente, se encargan de enlazar la animación que hemos realizado anteriormente al codigo de nuestro personaje; mientras que con el spriteRenderer podemos tener control del sprite del personaje, lo que nos va a permitir luego invertir la direccion al moverse a la derecha y/o izquierda en el mapa.

```C#
void Start()
{
  spriteRenderer = GetComponent<SpriteRenderer>();
  animator = GetComponent<Animator>();
}
```

Un metodo Start que nos permite obtener los componentes que hemos asignado para poder trabajar con el animator y el spriteRenderder del personaje.

```C#
void Update()
{
  float horizontalUpdate = Input.GetAxis("Horizontal");
  Vector2 movement = new Vector2(horizontalUpdate, 0);
  transform.Translate(movement * speed * Time.deltaTime);

  if(horizontalUpdate > 0)
  {
    spriteRenderer.flipX = false;
  } 
  else if (horizontalUpdate < 0)
  {
    spriteRenderer.flipX = true;
  }

  animator.SetBool("isWalking", horizontalUpdate != 0);
}
```

En el Update, queremos detectar con el sistema viejo, el movimiento "Horizontal", lo que nos automatiza las teclas correspondientes para el movimiento horizontal del personaje, de forma que con el movimiento asignado a un vector que solo mueve la dirección X, y fuerza la dirección Y a 0.

Luego con el _Translate()_ realizamos el movimiento normalizado con el _Time.DeltaTime_ y aqui participa el spriteRenderer, dado a que segun si detectamos un movimiento superior a 0, nos moveremos a la derecha, lo cual pide enderezar el sprite hacia su dirección natural, mientras que si detectamos un movimiento inferior a 0, nos moveremos a la izquierda, lo que requiere invertir el sprite hacia su dirección contraria.

La linea final se encarga de activar el flag de que el animator proceda a moverse al estado de _isWalking_ en el que se ve la animación de movimiento.

En la ejecucción se ve de esta forma
![movimiento](./Media/movimiento_main_character.gif)



## 4. Conclusiones
Gracias a esta práctica, podemos tener unas nociones esenciales de como 

## 5. Bibliografía
1. **Enunciado de la práctica:** [https://campusvirtual.ull.es/2627/doctoradoyposgrado/mod/assign/view.php?id=23548](https://campusvirtual.ull.es/2627/doctoradoyposgrado/mod/assign/view.php?id=23548)

2. **Guión de la práctica:** [https://docs.google.com/document/d/14T_HCzmx1xAshkD94H7dGztcy1F3adwIi1UPQeZu1VY/edit?tab=t.0](https://docs.google.com/document/d/14T_HCzmx1xAshkD94H7dGztcy1F3adwIi1UPQeZu1VY/edit?tab=t.0)

2. **Transparencias Sprites 2D:** [https://docs.google.com/presentation/d/1ZEZmTA6Kf83pr9CtNvuMpc4Y6voRO2me_BPLSD_GpfI/edit?slide=id.p1#slide=id.p1](https://docs.google.com/presentation/d/1ZEZmTA6Kf83pr9CtNvuMpc4Y6voRO2me_BPLSD_GpfI/edit?slide=id.p1#slide=id.p1)

