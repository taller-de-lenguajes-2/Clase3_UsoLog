# Clase3: Uso de Log en una aplicación WPF
## Logs [según wikipedia]

En informática, se usa el término log, historial de log o registro, se refiere a la grabación secuencial en un archivo o en una base de datos de todos los acontecimientos (eventos o acciones) que afectan a un proceso particular (aplicación, actividad de una red informática, etc.). De esta forma constituye una evidencia del comportamiento del sistema.

[referencia de wikipedia](https://es.wikipedia.org/wiki/Log_(inform%C3%A1tica))

## Usando la librería de log en proyectos Wpf.

Podemos Utiliza la libería NLog como base para loggear eventos importantes de una aplicación de .Net 

### Agregar La librería Nlog a nuestro proyecto 

Esto se puede hacer desde la consola de Nlog, para ello vamos a seguir los pasos
1. Ir a la Consola nuget 

![abrir la consola nuget](https://github.com/Spktro/Clase3_UsoLog/blob/master/NugetPackageManager.png)

2. ejecutar el comando para instalar la Nlog: Install-Package NLog -Version 4.6.7 

Aquí pueden ver la versión más reciente de Nlog, el historial de versiones por si necesitan instalar una versión anterior y demás datos relacionados a NLOG: (https://www.nuget.org/packages/NLog/)


### Debemos agregar la referencia 
using NLog;

### Debemos agregar el archivo de configuración xml en la raiz de nuestro proyecto 
```xml
<?xml version="1.0" encoding="utf-8" ?>
<nlog xmlns="http://www.nlog-project.org/schemas/NLog.xsd"
      xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
      xsi:schemaLocation="http://www.nlog-project.org/schemas/NLog.xsd NLog.xsd"
      autoReload="true"
      throwExceptions="false"
      internalLogLevel="Off" internalLogFile="c:\temp\nlog-internal.log">

  <!-- optional, add some variables
  https://github.com/nlog/NLog/wiki/Configuration-file#variables
  -->
  <variable name="myvar" value="myvalue"/>

  <!--
  See https://github.com/nlog/nlog/wiki/Configuration-file
  for information on customizing logging rules and outputs.
   -->
  <targets>
    <!--
    add your targets here
    See https://github.com/nlog/NLog/wiki/Targets for possible targets.
    See https://github.com/nlog/NLog/wiki/Layout-Renderers for the possible layout renderers.
    -->
    <!--  Write events to a file with the date in the filename.  -->
    <target xsi:type="File" name="f" fileName="${basedir}/logs/${shortdate}.log"
            layout="${longdate} ${uppercase:${level}} ${message} ${exception}" />   
  </targets>

  <rules>
    <!-- add your logging rules here -->

    <!--
    Write all events with minimal level of Debug (So Debug, Info, Warn, Error and Fatal, but not Trace)  to "f"  -->
    <logger name="*" minlevel="Debug" writeTo="f" />
   
  </rules>
</nlog>

```


### Diferentes niveles de logs en la librería NLOG

logger.Trace("logeo de mensaje de trace");

logger.Debug("logeo de mensaje de debug");

logger.Info("logeo de mensaje de informational");

logger.Warn("logeo de mensaje de warning");

logger.Error("logeo de mensaje de error ");

logger.Fatal("logeo de mensaje de error fatal");


