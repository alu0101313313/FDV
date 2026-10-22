# Practica 01: Herramienta Git LFS
<sup> José Javier Ramos Carballo, [alu0101313313](https://github.com/alu0101313313)


## Indice

1. [Introducción](#1-introducción)
2. [Tareas a Realizar](#2-tareas-a-realizar)
3. [Desarrollo](#3-desarrollo)
4. [Conclusiones](#4-conclusiones)
5. [Bibliografía](#5-bibliografía)


## 1. Introducción
En esta práctica de la asignatura [Fundamentos del Desarrollo de Videojuegos](https://campusvirtual.ull.es/2627/doctoradoyposgrado/course/view.php?id=2627110295), nos encargaremos de trabajar con la herramienta GIT LFS, la cual nos permite subir archivos de mayor peso en nuestros repositorios.

## 2. Tareas a Realizar

  - [ ] Crear un proyecto Unity que incluya 2 Objetos en 3D.
  - [ ] Crear un repositorio Github para subir el proyecto Unity.
  - [ ] Instalar la herramienta GIT LFS para el proyecto anterior.
  - [ ] Realizar un script que confirme la correcta ejecucción del proyecto.

## 3. Desarrollo

Para comenzar, crearemos un proyecto de Unity, en el cual se incluyan 2 Objetos en 3D, para ello accederemos al Unity Editor, y crearemos un nuevo proyecto en 3D, y en cual, cuando se inicialize, crearemos dos objetos en 3D.

- [x] Crear un proyecto Unity que incluya 2 Objetos en 3D.

![proyecto_con_2_objetos](./media/proyecto_con_2_objetos.png)

Luego, tenemos que crear un repositorio en Github y desde una consola en la carpeta del proyecto, debemos enlazar el proyecto local de Unity con el repositorio creado en Github.

- [x] Crear un repositorio Github para subir el proyecto Unity. 

![repositorio_inicial_en_github](./media/repositorio_inicial_en_github.png)

Desde este punto podemos subir los cambios que se hayan realziado en el proyecto local de Unity hacia el repositorio en la nube de Github.

Por ello, probaremos a añadir un material, la cual en este caso la hemos asignado a la esfera creada.

![material_bola_de_asero](./media/material_bola_de_asero.png)

Ahora, lo que queremos probar sera a meter archivos con un gran tamaño, en nuestro caso, con ficheros mayores a 100Mb nos vale.

Para ello, desde la carpeta raiz del proyecto, incluiremos un fichero de gran tamaño, el cual intentaremos pushear al repositorio Github.

Cuando lo intentamos realizar, desde la consola nos salta este error.

![git_push_explota](./media/git_push_explota.png)

Precisamente, en la captura podemos ver como nos tira errores señalando el problema con el volumen del fichero, y como precisamente nos recomienda la herramienta de la cual se trata en esta práctica: **GIT LFS**

Para ello, procederemos a instalar esta herramienta con el sigueinte comando 

```bash
git lfs install
```

y luego deberas utilizar, el siguiente comando

```bash
git init
```

> [!NOTE]
> Si ya tienes un proyecto, y ya tienes instalado los comandos, igualmente al ejecutarlos, estos "se reinician" para que su funcionamiento se habilite dentro del proyecto en el que se trabaja.

Una vez, preparado, debemos indicarle que tipo de ficheros deben tener seguimiento para GIT LFS, para que pueda subir aquellos tipos de ficheros de gran tamaño.

Para ello, debemos realizar el siguiente comando:

```bash
git lfs track "*.zip"
```

En este caso, hemos preparado para que GIT LFS haga un seguimiento de todos los archivos comprimidos en el formato _.zip_, tambien se pueden añadir otros formatos recomendados como _.png_ o _.fbx_.

Con este comando tambien se genera el fichero _.gitattributes_ en la raíz del proyecto, el cual lleva la lista de estas opciones que hemos añadido.

Con estas configuraciones realizadas, para evitar problemas con el commit que intentamos subir con los archivos de gran tamaño, debemos revertir dicho commit, para ello, debemos ejecutar el comando

```bash
git reset <ID del commit previo al commit con fichero grandes>
```

Con esto volvemos al commit previo al que guarda los ficheros grandes, y desde ahi, realizamos el commit y el push de nuevo con los ficheros de gran tamaño ya trackeados por GIT LFS. En caso correcto, asi se debe ver cuando se realiza este proceso.

- [x] Instalar la herramienta GIT LFS para el proyecto anterior.

![git_push_ya_no_explota](./media/git_push_ya_no_explota.png)

Una vez realizado todo este proceso y viendo desde Github, el fichero de gran tamaño, lo que se nos pide para finalizar, es realizar un script sencillo que muestre por consola _"Script tarea 1.1"_

Para ello, creamos un MonoBehaviourScript, en el cual asignamos a uno de los objetos 3D de la escena, el cual tiene el siguiente contenido

```C#
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Script tarea 1.1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
```

Si lo hemos asignado correctamente, deberia ocurrir lo siguente:

- [x] Realizar un script que confirme la correcta ejecucción del proyecto.

![ejecucción_gif](./media/ejecucción_script.gif)

## 4. Conclusiones
Gracias a esta práctica, podemos tener unas nociones esenciales de como tener un proyecto de Unity enlazado a un repositorio de Github, lo cual lo permite hacer muy accesible si te tiene la conexión con el repositorio.

Además gracias tambien a la adicción de la herramienta **GIT LFS**, hemos podido subir archivos considerados de gran tamaño, lo cual sera util para añadir elementos audiovisuales necesarios para proyectos avanzados en este motor.

## 5. Bibliografía
1. **Enunciado de la práctica:** [https://campusvirtual.ull.es/2627/doctoradoyposgrado/mod/assign/view.php?id=23506](https://campusvirtual.ull.es/2627/doctoradoyposgrado/mod/assign/view.php?id=23506)

2. **Guión de la práctica:** [https://docs.google.com/document/d/1-hQ_XFYJh3NXTkmyNvRaJdqdsEcT55-Ku8L2ii5nqYA/edit?tab=t.0#heading=h.rb6z1r2u4n1s](https://docs.google.com/document/d/1-hQ_XFYJh3NXTkmyNvRaJdqdsEcT55-Ku8L2ii5nqYA/edit?tab=t.0#heading=h.rb6z1r2u4n1s)

3. **Tabla comparativa de comandos:** [https://campusvirtual.ull.es/2627/doctoradoyposgrado/mod/url/view.php?id=23661](https://campusvirtual.ull.es/2627/doctoradoyposgrado/mod/url/view.php?id=23661)
>>>>>>> 32cf20c75a983781dbc17b2914d28ef02da7be2e
