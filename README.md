# Clase3: Uso de Log en una aplicación WPF
## Logs [según wikipedia]

En informática, se usa el término log, historial de log o registro, se refiere a la grabación secuencial en un archivo o en una base de datos de todos los acontecimientos (eventos o acciones) que afectan a un proceso particular (aplicación, actividad de una red informática, etc.). De esta forma constituye una evidencia del comportamiento del sistema.

[referencia de wikipedia](https://es.wikipedia.org/wiki/Log_(inform%C3%A1tica))

## Ejemplo de uso de log en proyectos Wpf.

Se Utiliza la libería NLog como base para loggear eventos importantes de una programa 



Se puede agregar Nlog desde la consola de Nuget con el siguiente comando:
https://www.nuget.org/packages/NLog/

![abrir la consola nuget](https://docs.aspose.com/download/attachments/9218557/NugetPackageManager.png)


## Diferentes niveles de logs en la librería NLOG

logger.Trace("logeo de mensaje de trace");

logger.Debug("logeo de mensaje de debug");

logger.Info("logeo de mensaje de informational");

logger.Warn("logeo de mensaje de warning");

logger.Error("logeo de mensaje de error ");

logger.Fatal("logeo de mensaje de error fatal");


