# LABERINTO
JUEGO LABERINTO CON UNITY
# Estructura del Proyecto
├── Assets/

│   ├── Scenes/
│   │   ├── Menu.unity        # Escena menu.
│   │   ├── Nivel1.unity        # Escena nivel 1 del juego
│   │   └── EscenaPrincipal.unity      # Escena nivel 2 del juego
│   ├── Scripts/
│   │   ├── ContadorBonus.cs         # Actualiza el bonus.
│   │   ├── ControlAudio.cs       # Control del audio pausa y despausar.
│   │   ├── DeteccionManzana.cs         # Detectar colision manzana.
│   │   ├── DeteccionMeta.cs    # Detectar colision meta.
│   │   ├── GestorEstado.cs  # Gestiona el estado del jugador.
│   │   ├── GestorJuego.cs       # Gestiona el estado del juego.
│   │   ├── GestorMenu.cs         # Gestiona el movimiento entre escena del menu.
│   │   ├── InputManager.cs       # detecta inputs.
│   │   ├── MovimientoJugador.cs         # Lee input y mueve objeto jugador.
│   │   ├── SonidoColision.cs    # Emite sonido tras la colision.
│   │   ├── SonidoColisionManzana.cs  # Emite sonido tras la colision con manzana.
│   │   ├── SonidoColisionPunto.cs       # Emite sonido tras la colision bonus.
│   │   ├── Vistaestado.cs       # Encarga de mostrar por pantalla el estado jugador.
│   │   └── VistaVelocidad.cs    # Encarga de mostrar por pantalla la velocidad jugador.
│   ├── Audio/
│   │   └── [Efectos y música .mp3/.wav]
│   └── Materials/                     # Materiales y texturas visuales
└── README.md                          # Documentación del proyecto (Actualizado)
# Controles del Juego
W / A / S / D o Flechas de dirección: Mover al personaje.

U / P: Interactuar del juego despausar y pausar.
# Cómo Empezar
1.  clonar repositorio:
    git clone https://github.com/tu-usuario/tu-repositorio.git
2.  Abrir el proyecto: Añade la carpeta raíz en Unity Hub.
3.  Ejecución: Abre la escena `EscenaPrincipal.unity` dentro de `Assets/Scenes/` y presiona **Play**.
