# Generala - TP DAS

Aplicación Windows Forms (.NET Framework 4.7.2) en capas: **BE**, **DAL**, **BLL** y **PRESENTACION** (`TPDAS_Generala`).

## Cómo dejarlo andando

1. **Base de datos**: abrir `BaseDeDatos/GENERALA.sql` en SQL Server Management Studio y ejecutarlo
   (crea la base `GENERALA`, las tablas y los procedimientos almacenados).
   La cadena de conexión está en `DAL/Acceso.cs` (`Data Source=.;Integrated Security=True`);
   si usás SQL Express cambiá `Data Source=.` por `Data Source=.\SQLEXPRESS`.
2. Abrir `TPDAS_Generala.slnx` en Visual Studio, dejar **PRESENTACION** como proyecto de inicio y ejecutar (F5).

## Cómo se juega

1. Al abrir aparece el login. Con **Crear cuenta nueva** se registra un usuario; después **Iniciar sesión**.
2. Iniciar sesión con un segundo usuario (menú *Usuarios → Iniciar sesión / Registrarse*, `Ctrl+L`).
3. *Juego → Nueva partida* (`Ctrl+N`), elegir los dos jugadores.
4. En cada turno: **Tirar dados** (hasta 3 veces). Clic en un dado para retenerlo entre tiradas.
   La planilla muestra en gris cuántos puntos sumaría cada categoría libre.
   Para anotar: doble clic en la categoría o seleccionarla y **Anotar**. Si vale 0, se tacha (X).
5. Al completar las 10 categorías se guarda la partida y se muestra el ganador.

Menús extra: *Consultas → Estadísticas / Bitácora* y *Administración → Backup y Restore*.
