# dron_controller
## Requisitos

- Visual Studio 2022
- GOLD Parser Engine DLL

## Configuraci�n

### Paso 1: Descargar la DLL de GOLD Parser Engine

1. Ve a la [p�gina de descargas de GOLD Parser Engine](http://www.goldparser.org/download/) y descarga la �ltima versi�n de la DLL.
2. Guarda el archivo `GOLDParserEngine.dll` en una ubicaci�n accesible en tu sistema.

### Paso 2: Remover la Referencia Existente

1. Abre el proyecto en Visual Studio 2022.
2. En el `Solution Explorer`, busca y elimina la referencia existente a `GOLDParserEngine.dll`.

### Paso 3: Agregar la Nueva Referencia

1. Haz clic derecho en el proyecto en el `Solution Explorer` y selecciona `Add` > `Reference`.
2. En el `Reference Manager`, selecciona `Browse` y navega a la ubicaci�n donde guardaste `GOLDParserEngine.dll`.
3. Selecciona la DLL y haz clic en `Add`.
4. Aseg�rate de que la referencia est� seleccionada y haz clic en `OK`.
