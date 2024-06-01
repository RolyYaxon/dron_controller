# dron_controller
## Requisitos

- Visual Studio 2022
- GOLD Parser Engine DLL

## Configuración

### Paso 1: Descargar la DLL de GOLD Parser Engine

1. Ve a la [página de descargas de GOLD Parser Engine](http://www.goldparser.org/download/) y descarga la última versión de la DLL.
2. Guarda el archivo `GOLDParserEngine.dll` en una ubicación accesible en tu sistema.

### Paso 2: Remover la Referencia Existente

1. Abre el proyecto en Visual Studio 2022.
2. En el `Solution Explorer`, busca y elimina la referencia existente a `GOLDParserEngine.dll`.

### Paso 3: Agregar la Nueva Referencia

1. Haz clic derecho en el proyecto en el `Solution Explorer` y selecciona `Add` > `Reference`.
2. En el `Reference Manager`, selecciona `Browse` y navega a la ubicación donde guardaste `GOLDParserEngine.dll`.
3. Selecciona la DLL y haz clic en `Add`.
4. Asegúrate de que la referencia esté seleccionada y haz clic en `OK`.
