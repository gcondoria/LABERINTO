# LABERINTO
JUEGO LABERINTO CON UNITY
# Estructura del Proyecto
├── Assets/
│   ├── Scenes/
│   │   └── EscenaPrincipal.unity      # Escena base del juego (Actualizada)
│   ├── Scripts/
│   │   ├── ControladorJugador.cs      # Lógica del personaje (Refactorizado)
│   │   ├── MovimientoFisico.cs        # Sistema de físicas personalizado (Nuevo)
│   │   ├── PropiedadesObjeto.cs       # Datos de los objetos del entorno (Puede mejorarse)
│   │   ├── GestorAudio.cs             # Administrador de efectos y música (Nuevo)
│   │   └── InterfazUI.cs              # Control de menús y HUD (Nuevo)
│   ├── Audio/
│   │   └── [Efectos y música .mp3/.wav]
│   └── Materials/                     # Materiales y texturas visuales
└── README.md                          # Documentación del proyecto (Actualizado)
# Controles del Juego
W / A / S / D o Flechas de dirección: Mover al personaje.

U / I / O / P: Interactuar con el audio del juego.
# Cómo Empezar
1.  clonar repositorio:
    git clone https://github.com/tu-usuario/tu-repositorio.git
2.  Abrir el proyecto: Añade la carpeta raíz en Unity Hub.
3.  Ejecución: Abre la escena `EscenaPrincipal.unity` dentro de `Assets/Scenes/` y presiona **Play**.
