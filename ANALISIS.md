# Evaluación del proyecto `juegoRPG` frente al trabajo "Mini RPG – Evolución del Sistema de Combate"

**Fecha:** 05-10-2026
**Proyecto evaluado:** `C:\Users\vicen\source\repos\juegoRPG\juegoRPG\`
**Pauta:** `trabajo.pdf` (Taller de Programación I – Trabajo Grupal, 100 pts)
**Compilación:** ✅ `Compilación correcta` — 0 errores
(las 10 advertencias `MSB3026` son solo porque el `.exe` estaba corriendo durante la compilación, no es un problema de código)

---

## 1. Veredicto

**Esta es la mejor base de las dos y conviene seguir con esta.** Comparado con `juegos.trabajo`,
el código está más limpio, el diseño no tiene basura y el balance del juego ya es jugable.

Pero el estado frente a la pauta es el mismo en lo esencial: **faltan 4 misiones completas** y
sigue en pie la violación de la "Regla principal" y de la Misión 2.

| | |
|---|---|
| Misiones cumplidas | **3** de 12 |
| Misiones parciales | **5** |
| Misiones ausentes | **4** |
| Hallazgos | **31** |
| Casos límite de la Misión 11 que fallan | **5** de 10 |

---

## 2. Lo que ya mejoró respecto a `juegos.trabajo`

Esto no es relleno: son 13 cosas que ya no hay que arreglar.

### En la lógica

1. **La vida la escribe el usuario** (`txtVidaGuerrero` / `txtVidaEnemigo`) en vez de calcularse
   como `100 + nivel*10`. Ahora `VidaMaxima` es un dato real y configurable.
2. **Los rangos son sensatos:** Nivel 1–5, Ataque 1–50, Defensa 0–40, Vida 1–100. Antes eran
   Nivel ≤ 99 y Ataque ≤ 999, con lo que un golpe mataba de inmediato. **El juego ahora está
   balanceado.**
3. **La variación aleatoria quedó en una escala razonable.** `azar.Next(0, Nivel+1)` da 0–5 sobre
   un ataque de 1–50; antes daba 0–99 sobre el ataque y lo dominaba por completo.
4. **`IntentarIniciarCombate()` ahora exige que ambos estén vivos**, no solo que existan.
5. **`RecibirDano()` devuelve `void`.** Antes devolvía el mismo daño que se le acababa de pasar
   como parámetro, lo que no servía para nada.
6. **Se eliminaron los `SelectedIndexChanged`** de los ComboBox, que solo movían el foco.

### En el diseño

7. **No hay controles huérfanos.** Desaparecieron `textBox9` y el `button3` que decía "Atacar" y
   no hacía nada.
8. **No hay manejadores de evento vacíos.** Desapareció `groupBox1_Enter`.
9. **Los 6 eventos conectados son todos reales** y todos tienen su método.
10. **Labels bien nombrados:** `lblAtaqueGuerrero` / `lblAtaqueEnemigo`, en vez de los
    `lblDañoGuerrero` con `ñ` en el identificador y que además mostraban "Ataque".
11. **`Text = "-"` como valor inicial** en los 10 labels de estado: la pantalla no arranca vacía.
12. **Los `PictureBox` tienen `BackColor = ActiveBorder`**, así que el hueco de la imagen ya está
    reservado y se ve en el diseño.
13. **El proyecto compila sin errores.**

---

## 3. Estado de las 12 misiones

| Misión | Tema | Estado |
|---|---|---|
| 1 | Evolucionar clase `Personaje` | ⚠️ Parcial — falta `ProbabilidadCritico` |
| 2 | Proteger el estado (encapsulamiento) | ❌ **No cumple** — las 8 propiedades son `set` público |
| 3 | Ataque y defensa | ✅ Cumple |
| 4 | Daño variable | ⚠️ Parcial — existe, pero atada al Nivel y solo hacia arriba |
| 5 | Golpes críticos | ❌ **Ausente** |
| 6 | Estados de vida + imágenes | ❌ **Ausente** |
| 7 | Curación limitada | ⚠️ Parcial — no impide curar a un derrotado |
| 8 | Sistema de turnos | ✅ Cumple |
| 9 | 3 enemigos distintos + aleatorio | ❌ **Ausente** — solo hay 3 *nombres* |
| 10 | Interfaz del combate | ⚠️ Parcial — faltan imágenes, crítico, historial, Nueva Partida |
| 11 | Intentar romper el juego | ⚠️ 5 de 10 casos fallan |
| 12 | 2 mecánicas propias | ❌ **Ausente** |
| — | `README.txt` de entrega | ❌ **Ausente** (el `README.md` tiene 10 bytes) |

---

## 4. Inventario del código

### 4.1 `Personajes.cs`

```
Constantes    MaximoPociones = 3 · CuraPorPociones = 25
Catálogos     Clases[]         = {Guerrero, mago, caballero}
              ClasesEnemigos[] = {orco, duende, brujo}
Propiedades   Nombre · ClasePersonaje · Vida · Ataque · Nivel
              Defensa · VidaMaxima · Pociones     ← todas get/set público
              EstaVivo                             (solo lectura, calculada)
Constructor   Personajes(nombre, clasePersonaje, nivel, defensa, vida, ataque, pociones)
              → clamp de pociones a [0..3] ; VidaMaxima = vida ; Vida = vida
Métodos       CalcularDano(objetivo, Random) → Ataque + azar(0..Nivel) - Defensa/2, mínimo 1
              RecibirDano(dano)  → void, resta vida, clamp inferior en 0
              UsarPocion()       → gasta 1, cura 25, clamp en VidaMaxima
```

### 4.2 `Form1.cs`

```
Estado      guerrero · enemigo (Personajes?) · azar (Random) · bitacora (List<string>)
            turnoDelGuerrero · partidaEnCurso · numeroDeTurnos
Setup       PrepararCombos() · PrepararCamposDeEstadisticas()
Creación    btnCrearGuerrero_Click / btnCrearEnemigo_Click
            → LeerPersonajeDeLaPantalla() → LeerNumero()
Combate     IntentarIniciarCombate() · Atacar() · UsarPocion() · CambiarTurno()
Fin         TerminarPartida()   ← contiene un bloque TODO sin implementar
Vista       RefrescarPantalla() · MostrarGuerrero() · MostrarEnemigo() · ActualizarBotones()
```

### 4.3 `Form1.Designer.cs`

**48 controles, jerarquía limpia:**

```
Form1  (ClientSize 1068x639 · Text = "Form1")
├── groupBox1  "Crea Tu Guerrero"
│   ├── groupBox3 "Estadisticas"
│   │   ├── txtNombreGuerrero · comboBox1 · txtNivelGuerrero · txtAtaqueGuerrero
│   │   │   txtDefensaGuerrero · txtVidaGuerrero · txtPocionesGuerrero
│   │   ├── btnCrearGuerrero
│   │   └── label1 · label2 · label3 · label4 · label5 · label6 · label7
│   ├── pictureBox1              ← SIN Image y SIN SizeMode
│   ├── progressBar1
│   ├── lblNombreGuerrero · lblVidaGuerrero · lblNivelGuerrero
│   │   lblAtaqueGuerrero · lblDefensaGuerrero
│   └── btnAtacarGuerrero · btnPocionesGuerrero
└── groupBox2  "Crea Tu Enemigo"      (estructura espejo exacta)
    ├── groupBox4 "Estadisticas" + btnCrearEnemigo + comboBox2
    ├── pictureBox2              ← SIN Image y SIN SizeMode
    ├── progressBar2
    ├── lblNombreEnemigo · lblVidaEnemigo · lblNivelEnemigo
    │   lblAtaqueEnemigo · lblDefensaEnemigo
    └── btnAtacarEnemigo · btnPocionesEnemigo
```

**Eventos conectados (6, todos reales):** los 2 Crear, los 2 Atacar, los 2 Pociones.

**Controles que la pauta pide y NO existen:**
`btnNuevaPartida`, `lstHistorial` (ListBox), `lblCriticoGuerrero`, `lblCriticoEnemigo`,
`lblPocionesGuerrero`, `lblPocionesEnemigo`.

---

## 5. Hallazgos

### 🔴 Bloqueantes

---

**B1 — El encapsulamiento no existe. Viola la Misión 2 literalmente.**

Las ocho propiedades de `Personajes` son `public ... { get; set; }`. El ejemplo exacto que la
pauta prohíbe compila y funciona hoy:

```csharp
guerrero.Vida = -5000;       // ✗ compila
enemigo.Vida  = 999999;      // ✗ compila
guerrero.Pociones = 100;     // ✗ compila, salta el límite de 3
guerrero.VidaMaxima = 1;     // ✗ compila, deja la vida sobre el máximo
```

El clamp de pociones del constructor queda inútil, porque después se puede escribir la propiedad
directamente.

**Corrección:** `{ get; private set; }` en `Vida`, `VidaMaxima`, `Ataque`, `Defensa`, `Pociones`,
`Nivel`; toda modificación de vida solo vía `RecibirDanio()` y `Curar()`.

---

**B2 — No hay golpes críticos. Misión 5 completa sin implementar.**

No existe `ProbabilidadCritico` —que la Misión 1 exige como propiedad mínima—, ni
`EsGolpeCritico()`, ni el multiplicador ×2, ni el aviso `¡GOLPE CRÍTICO!` en el historial.

---

**B3 — No hay imágenes ni estados de vida. Misión 6 completa sin implementar.**

- No existe `CalcularPorcentajeVida()`.
- **No hay ningún archivo de imagen en el proyecto** (búsqueda de png/jpg/gif/bmp/ico: 0 resultados).
- `Form1.resx` es **byte por byte idéntico a la plantilla por defecto** de Visual Studio: sus
  únicas entradas `data` son los ejemplos comentados `Name1`/`Color1`/`Bitmap1`/`Icon1`.
- No existe carpeta `Properties` ni `Resources.resx`.
- `pictureBox1` y `pictureBox2` tienen `BackColor` pero **ni `Image` ni `SizeMode`**: cualquier
  imagen que se les asigne saldrá recortada.

Es la misión más caliente, porque la pauta le dedica dos páginas completas ("Desafío visual") y
el checklist la pregunta aparte.

---

**B4 — No hay 3 enemigos reales ni selección aleatoria. Misión 9 sin implementar.**

```csharp
public static readonly string[] ClasesEnemigos = { "orco", "duende", "brujo" };
```

Es **solo un arreglo de nombres**: no hay estadísticas asociadas a cada enemigo. Hoy el usuario
escribe a mano la vida, el ataque y la defensa del enemigo, y además lo elige él mismo desde
`comboBox2`. La pauta pide lo contrario:

> "Al comenzar una nueva partida, uno de los enemigos disponibles deberá seleccionarse
> aleatoriamente."

**En todo el proyecto no hay ni una llamada a `Random` para elegir enemigo.** El único uso de
`azar` es la variación del daño.

---

**B5 — No existe el botón Nueva Partida ni el reinicio.**

`TerminarPartida()` termina con un TODO:

```csharp
// ===== TODO (esta parte la haces tu) =====
// 1) Mostrar la historia de la pelea usando la lista "bitacora", ...
// 2) Dejar el tablero limpio para crear personajes nuevos.
// poner imagenes de los personajes en la pantalla de victoria y derrota, ...
```

La Misión 10 exige un `Button` "Nueva Partida" que no está en el Designer, y el checklist pide
"Nueva Partida reinicia el juego".

*Nota a favor:* a diferencia de `juegos.trabajo`, este TODO **no nombra métodos inexistentes**, así
que no hay riesgo de romper la compilación al descomentarlo.

---

**B6 — El historial del combate no se muestra en ninguna parte.**

`bitacora` se llena correctamente turno por turno —incluido el mensaje de apertura y el de
derrota— pero **nunca se lee**. No hay `ListBox` en el formulario. La Misión 10 lo pide
explícitamente: "Historial del combate", "Pueden utilizar … `ListBox`".

Es la corrección más rentable del proyecto: los datos ya están armados, solo falta el control
donde mostrarlos.

---

**B7 — No hay mecánicas propias. Misión 12 sin implementar.**

Se exigen al menos 2 reglas nuevas. No hay ninguna. Las pociones y el nivel **no cuentan**: son
parte del requisito base.

---

**B8 — Falta el `README.txt` de entrega.**

La pauta lo exige con 9 puntos obligatorios. El `README.md` del repositorio dice `# juegoRPG` y
nada más (10 bytes).

---

### 🟠 Importantes

---

**I9 — El formulario es el cerebro del juego. Choca con la "Regla principal".**

Viven en `Form1.cs`, no en una clase de dominio:

- el orden de los turnos (`turnoDelGuerrero`, `CambiarTurno()`),
- el contador de turnos (`numeroDeTurnos`),
- la detección de victoria (`if (!defensor.EstaVivo) TerminarPartida(...)`),
- la bitácora completa del combate,
- la orquestación del ataque (`CalcularDano` + `RecibirDano` se combinan en `Atacar()` del Form).

**Corrección:** una clase `Combate` con los dos personajes, el turno, el registro y los métodos
`EjecutarAtaque()`, `EjecutarPocion()`, `HayGanador()`.

---

**I10 — La variación del daño sigue atada al Nivel y sigue siendo solo hacia arriba.**

```csharp
int suerte = azar.Next(0, Nivel + 1);              // depende del NIVEL, no del ataque
int dano = Ataque + suerte - (objetivo.Defensa / 2);
```

Con los rangos nuevos (Nivel 1–5) el problema de escala ya está resuelto —esto es una mejora
real—, pero quedan dos defectos de diseño:

1. **La variación depende del nivel, no del ataque base.** La pauta pide una variación
   *alrededor del ataque* (Ataque 30 → aprox. 27–33). Aquí un personaje nivel 1 varía 0–1 y uno
   nivel 5 varía 0–5, sin importar si su ataque es 5 o 50.
2. **La variación nunca es negativa** (`0..Nivel`). El daño jamás baja del ataque base, así que
   no es una variación simétrica: es un bono.

**Corrección:** ±10 % sobre el ataque base, p. ej. `azar.Next(-(Ataque/10), (Ataque/10)+1)`.

*Sobre la fórmula de defensa:* usar `Defensa / 2` en vez de `Ataque - Defensa` es una desviación
de la pauta, pero **la pauta la permite explícitamente** ("El grupo puede proponer una fórmula
diferente si es coherente y puede justificarla"). Con Defensa hasta 40 y Ataque hasta 50, restar
la defensa completa dejaría peleas eternas, así que hay buen argumento. **Hay que escribirlo en
el `README.txt`.**

---

**I11 — No se impide curar a un personaje derrotado.**

`UsarPocion()` no consulta `EstaVivo`. Hoy queda tapado porque al morir se pone
`partidaEnCurso = false` y los botones se deshabilitan, pero **la clase sí lo permite**, y la
Misión 11 pregunta exactamente eso. La validación debe estar en la clase, no en el estado de los
botones.

---

**I12 — `RecibirDano()` acepta daño negativo y cura sin tope.**

```csharp
public void RecibirDano(int dano)
{
    Vida = Vida - dano;
    if (Vida < 0) Vida = 0;
}
```

`RecibirDano(-500)` sube la vida 500 puntos **sin clamp contra `VidaMaxima`**. Hay que ignorar o
rechazar los valores negativos.

---

**I13 — Incoherencia en la validación de pociones.**

```csharp
if (!LeerNumero(txtPociones, "Pociones", 0, 20, out pociones)) return null;
```

Valida hasta **20**, y recién después muestra un `MessageBox` y recorta a 3. Pero el
`PlaceholderText` del mismo campo dice `"0 a 3"`. Debe validarse directo contra
`Personajes.MaximoPociones`, igual que los otros cinco campos.

---

**I14 — `ClasePersonaje` no tiene ningún efecto en el juego.**

Los dos ComboBox permiten elegir Guerrero/mago/caballero y orco/duende/brujo, pero
`ClasePersonaje` es un `string` decorativo: no modifica vida, ataque, defensa ni crítico. La clase
debería determinar las estadísticas base — es justo lo que la Misión 9 pide para los enemigos.

---

**I15 — Un `MessageBox` por turno es mala interfaz.**

Cada inicio de combate, cada fin de partida y cada error abren un modal. Con el `ListBox` del
historial (B6), los mensajes del combate deberían ir ahí.

---

**I16 — El constructor es una trampa: 5 parámetros `int` seguidos en orden contraintuitivo.**

```csharp
public Personajes(string nombre, string clasePersonaje,
                  int nivel, int defensa, int vida, int ataque, int pociones)
                            //  ↑ defensa ANTES de vida ANTES de ataque
```

El Form lo llama bien —de hecho hay un comentario que lo advierte: *"Ojo con el orden: asi esta
escrito el constructor de Personajes"*— pero **al ser cinco `int` consecutivos, cualquier
equivocación compila sin un solo error** y el bug aparece como un personaje con stats cambiados.
Un ataque de 90 y una defensa de 12 intercambiados no da ningún síntoma obvio.

Que el autor haya tenido que dejarse una nota a sí mismo es la señal de que el diseño está mal.

**Corrección:** reordenar a `(nombre, clase, nivel, vida, ataque, defensa, probabilidadCritico,
pociones)` —el orden en que aparecen en la pantalla— o usar argumentos con nombre en la llamada:
`new Personajes(nombre: n, vida: v, ataque: a, defensa: d, ...)`.

---

**I17 — Los clics ahora fallan en silencio.**

```csharp
private void btnAtacarGuerrero_Click(object sender, EventArgs e)
{
    if (!partidaEnCurso || !turnoDelGuerrero) return;   // sin ningún aviso
    Atacar(guerrero!, enemigo!);
}
```

La versión anterior tenía un `EsTurnoValido()` que explicaba *por qué* no se podía
("Primero tienes que crear los dos personajes", "No es tu turno"). Ahora el programa simplemente
no reacciona. Los botones están deshabilitados, así que en la práctica no se nota — pero es
feedback que se perdió.

---

**I18 — Tras una derrota hay que recrear a los DOS personajes, y nada lo dice.**

`IntentarIniciarCombate()` exige que ambos estén vivos:

```csharp
if (guerrero == null || enemigo == null || !guerrero.EstaVivo || !enemigo.EstaVivo)
{
    ActualizarBotones();
    return;
}
```

Entonces, si el enemigo muere y el usuario crea solo un guerrero nuevo, **la pelea no arranca y
no aparece ningún mensaje**: la ventana queda muerta y el usuario no sabe que le falta recrear al
enemigo. La lógica es correcta; falta el aviso. Se resuelve de raíz con el botón Nueva Partida (B5).

---

### 🟡 Diseño del formulario

---

**D19 — `Form1.Text = "Form1"`.** La ventana se llama "Form1" en la barra de título. Cambiar a
"Mini RPG". Falta también `StartPosition = CenterScreen`.

---

**D20 — Nombres de controles por defecto.** Sin renombrar: `groupBox1`–`groupBox4`,
`comboBox1`, `comboBox2`, `progressBar1`, `progressBar2`, `pictureBox1`, `pictureBox2`, y
`label1`–`label14`.

El resto del proyecto **sí** usa nombres buenos (`txtVidaGuerrero`, `btnPocionesEnemigo`,
`lblAtaqueGuerrero`), así que la inconsistencia se nota. Propuesta: `grpJugador`, `grpEnemigo`,
`grpFichaJugador`, `cboClaseJugador`, `pbVidaJugador`, `picJugador`.

---

**D21 — Los `PictureBox` no tienen `SizeMode`.** Están bien ubicados y con `BackColor` visible
(119×166 px), pero sin `SizeMode = Zoom` cualquier imagen saldrá recortada en vez de ajustarse.

---

**D22 — Pociones metidas dentro de la etiqueta de nivel.**

```csharp
lblNivelGuerrero.Text = "Nivel: " + guerrero.Nivel + "  |  Pociones: " + guerrero.Pociones;
```

La Misión 10 pide "Pociones restantes" como dato visible por derecho propio. Conviene un
`lblPocionesJugador` separado — y hará falta otro para el crítico.

---

**D23 — Layout 100 % absoluto, sin `Anchor` ni `Dock`.** `ClientSize = 1068×639` con todas las
posiciones fijas y `AutoScaleMode.Font`. Si se redimensiona la ventana o se abre con otro DPI, los
controles quedan cortados. Mínimo: `FormBorderStyle = FixedSingle` y `MaximizeBox = false`.

---

**D24 — Textos visibles inconsistentes.** Se ven en pantalla:

| Dónde | Dice | Debería decir |
|---|---|---|
| `btnPocionesGuerrero.Text` | `"pociones"` | `"Pociones"` (el del enemigo sí está capitalizado) |
| `Clases[]` | `{Guerrero, mago, caballero}` | todas capitalizadas |
| `ClasesEnemigos[]` | `{orco, duende, brujo}` | todas capitalizadas |
| `groupBox3` / `groupBox4` | `"Estadisticas"` | `"Estadísticas"` |

Son cuatro líneas de arreglo y la pauta evalúa la interfaz.

---

**D25 — Riesgo de entrega: formato de proyecto muy nuevo.**

- `juegoRPG.csproj` → `<TargetFramework>net10.0-windows</TargetFramework>`
- La solución es `juegoRPG.slnx` (formato XML nuevo); no hay `.sln` clásico.

Si el computador del profesor no tiene el SDK de .NET 10 o un Visual Studio que lea `.slnx`,
**el ZIP no abre ni compila**. Confirmarlo antes de entregar; si hay duda, bajar a
`net8.0-windows` y generar un `.sln` tradicional.

---

### ⚪ Menores

- **m26** — `using` redundantes: `System`, `System.Collections.Generic` y `System.Text` en
  `Personajes.cs` (el `.csproj` tiene `ImplicitUsings`), y `System.Text` además no se usa para nada.
- **m27** — La clase se llama `Personajes` (plural) pero representa **un** personaje. La pauta
  habla de `Personaje`.
- **m28** — `CuraPorPociones` debería ser `CuraPorPocion`: es cuánto cura **una** poción.
- **m29** — En el constructor, `Vida` se asigna dos veces (`Vida = vida;` arriba y otra vez abajo
  junto a `VidaMaxima = vida;`). Inofensivo, pero sobra.
- **m30** — Comentarios XML equivocados: `/// clase para los guerreros` sobre `Clases[]`, que es
  un arreglo de **nombres de clase**, no una clase; y la nota de tres líneas sobre qué es
  `public const` es un apunte de clase, no documentación de la API.
- **m31** — Uso repetido del operador `!` (null-forgiving): `Atacar(guerrero!, enemigo!)`. Se
  resuelve con la clase `Combate` de I9.

---

## 6. Misión 11 — prueba de casos límite

| Pregunta de la pauta | Resultado | Por qué |
|---|---|---|
| ¿Puede la vida quedar negativa? | ✅ No | `RecibirDano` hace clamp en 0 |
| ¿Puede la vida superar la máxima? | ❌ **Sí** | `Vida` y `VidaMaxima` tienen `set` público (B1); `RecibirDano(-n)` también (I12) |
| ¿Puede atacar un personaje muerto? | ⚠️ Solo por UI | Lo bloquean `partidaEnCurso` y el chequeo de `EstaVivo` en `IntentarIniciarCombate`, no la clase |
| ¿Poción sin tener pociones? | ✅ No | Validado en `UsarPocion()` y en el Form |
| ¿Puede curarse un derrotado? | ❌ **Sí a nivel de clase** | `UsarPocion()` no revisa `EstaVivo` (I11) |
| ¿Qué pasa si Defensa > Ataque? | ✅ Correcto | Daño mínimo forzado a 1 |
| ¿El crítico respeta su probabilidad? | ❌ N/A | No hay críticos (B2) |
| ¿La imagen cambia según el % de vida? | ❌ No | No hay imágenes ni cálculo de porcentaje (B3) |
| ¿Se detiene el combate al derrotar? | ✅ Sí | `TerminarPartida` apaga `partidaEnCurso` |
| ¿Nueva Partida reinicia todo? | ❌ No | No existe el botón ni el reinicio (B5) |

**5 de 10 fallan.** Los cuatro que pasan, pasan bien.

---

## 7. Modificaciones necesarias

### Etapa 1 — Cerrar la clase de dominio
*(B1, B2, I11, I12, I16, m27, m28)*

Renombrar `Personajes` → `Personaje`, proteger el estado y **arreglar el orden del constructor**:

```csharp
public class Personaje
{
    public const int MaximoPociones = 3;
    public const int CuraPorPocion  = 25;

    public string Nombre              { get; private set; }
    public string Clase               { get; private set; }
    public int    Nivel               { get; private set; }
    public int    Vida                { get; private set; }
    public int    VidaMaxima          { get; private set; }
    public int    Ataque              { get; private set; }
    public int    Defensa             { get; private set; }
    public int    ProbabilidadCritico { get; private set; }   // 0..100  ← NUEVO (Misión 1 y 5)
    public int    Pociones            { get; private set; }

    public bool EstaVivo => Vida > 0;

    // Orden igual al de la pantalla: nivel, vida, ataque, defensa, critico, pociones
    public Personaje(string nombre, string clase, int nivel, int vida, int ataque,
                     int defensa, int probabilidadCritico, int pociones) { /* clamps aquí */ }

    public int  CalcularPorcentajeVida()      // Misión 6: (Vida * 100) / VidaMaxima
    public bool EsGolpeCritico(Random azar)   // Misión 5: azar.Next(100) < ProbabilidadCritico
    public ResultadoAtaque Atacar(Personaje objetivo, Random azar)
    public void RecibirDanio(int cantidad)    // ignora negativos, clamp en 0
    public bool Curar(int cantidad)           // false si está derrotado o si cantidad <= 0
    public bool UsarPocion()                  // false si Pociones == 0 o si !EstaVivo
}
```

### Etapa 2 — Daño con crítico
*(B2, I10)*

Respetar el orden de la pauta: **ataque base → variación aleatoria → ¿crítico? → defensa del
objetivo → daño final.** Devolverlo en un tipo de resultado para que el Form escriba el historial
sin recalcular:

```csharp
public class ResultadoAtaque
{
    public int  Danio      { get; set; }
    public bool FueCritico { get; set; }
}
```

- **Variación:** aprox. ±10 % del ataque base (Ataque 30 → 27–33).
- **Crítico:** si `EsGolpeCritico()`, el daño ×2.
- **Defensa:** `Defensa / 2` se puede mantener, pero hay que justificarlo en el `README.txt`.
- **Mínimo 1** para que un ataque normal nunca cure al objetivo.

### Etapa 3 — Enemigos predefinidos y aleatorios
*(B4, I14)*

Reemplazar el arreglo de nombres por una tabla real y un método fábrica:

```csharp
private static readonly (string Nombre, int Vida, int Ataque, int Defensa, int Critico)[] Enemigos =
{
    ("Orco",    90, 22, 14, 15),
    ("Duende",  60, 16,  6, 25),
    ("Brujo",   70, 28, 10, 20),
};

public static Personaje CrearEnemigoAleatorio(Random azar)
{
    var e = Enemigos[azar.Next(Enemigos.Length)];
    return new Personaje(e.Nombre, e.Nombre, 3, e.Vida, e.Ataque, e.Defensa, e.Critico, MaximoPociones);
}
```

*(Los valores respetan los rangos que ya definiste: Vida ≤ 100, Ataque ≤ 50, Defensa ≤ 40.)*

Esto **elimina `groupBox4` completo** —`txtNombreEnemigo`, `comboBox2`, `txtNivelEnemigo`,
`txtAtaqueEnemigo`, `txtDefensaEnemigo`, `txtVidaEnemigo`, `txtPocionesEnemigo`,
`btnCrearEnemigo`, `label8`–`label14`— que hoy ocupa todo el cuadrante inferior derecho. **Ese
espacio liberado es exactamente donde va el `ListBox` del historial.**

### Etapa 4 — Clase `Combate`
*(I9, I15, I17, I18, m31)*

```csharp
public class Combate
{
    public Personaje Jugador { get; }
    public Personaje Enemigo { get; }
    public bool TurnoDelJugador { get; private set; }
    public int  NumeroDeTurno   { get; private set; }
    public bool Terminado       { get; private set; }
    public List<string> Historial { get; }

    public void AtacarJugador();     // ejecuta, registra en Historial y cambia el turno
    public void CurarJugador();
    public void TurnoDelEnemigo();   // ataque automático del enemigo
    public Personaje? Ganador { get; }
}
```

Después de esto cada manejador de evento debe caber en 3–5 líneas. La pauta advierte
específicamente contra un `btnAtacar_Click` de 80 líneas.

### Etapa 5 — Imágenes por estado de vida
*(B3, D21)*

1. Conseguir 5 imágenes por personaje (Proyecto → Propiedades → Recursos, o carpeta
   `Imagenes\` con **Build Action = Resource**): `normal`, `herido`, `muy_herido`, `critico`,
   `derrotado`.
2. En `Personaje`, un `enum EstadoVida` y una propiedad `Estado` derivada de
   `CalcularPorcentajeVida()`:

   | % de vida | Estado |
   |---|---|
   | 76–100 | Saludable |
   | 51–75 | Herido |
   | 26–50 | Muy herido |
   | 1–25 | Crítico |
   | 0 | Derrotado |

   **El cálculo va en la clase; elegir el archivo de imagen va en el Form.**
3. `picJugador.SizeMode = PictureBoxSizeMode.Zoom` en ambos PictureBox.
4. Asignar la imagen en `MostrarGuerrero()` / `MostrarEnemigo()`, que ya son los dos únicos
   lugares donde se refresca la pantalla.

### Etapa 6 — Completar el formulario
*(B5, B6, D19, D20, D22, D23, D24)*

**Agregar al Designer:**

| Control | Tipo | Para qué |
|---|---|---|
| `lstHistorial` | `ListBox` | Misión 10 — historial del combate |
| `btnNuevaPartida` | `Button` | Misión 10 + checklist |
| `lblCriticoJugador` / `lblCriticoEnemigo` | `Label` | Misión 10 — probabilidad de crítico |
| `lblPocionesJugador` / `lblPocionesEnemigo` | `Label` | Misión 10 — pociones restantes |

**Eliminar:** `groupBox4` completo si se adopta la Etapa 3.

**Renombrar:** los controles de D20.

**Propiedades del Form:** `Text = "Mini RPG"`, `StartPosition = CenterScreen`,
`FormBorderStyle = FixedSingle`, `MaximizeBox = false`.

**Arreglar los textos** de D24.

**Implementar el reinicio** y borrar el TODO de `TerminarPartida()`:

```csharp
private void btnNuevaPartida_Click(object sender, EventArgs e)
{
    // crea el jugador, sortea el enemigo con CrearEnemigoAleatorio(azar),
    // limpia lstHistorial, resetea el Combate y refresca la pantalla
}
```

### Etapa 7 — Dos mecánicas propias
*(B7)*

Dos que calzan con lo que ya existe y cuestan poco:

1. **Esquivar** — `ProbabilidadEsquivar` en `Personaje`; si el defensor esquiva, el daño es 0 y el
   historial lo anuncia. Reutiliza el mismo patrón de `EsGolpeCritico()`.
2. **Enfurecimiento** — bajo el 25 % de vida (el estado "Crítico" que ya hay que calcular para la
   Misión 6), el personaje gana un bono de ataque. Aprovecha directo `CalcularPorcentajeVida()`.

Otras válidas: veneno por turnos, bloqueo, ataque especial con recarga, regeneración.
**No sirven** cambios de color, fuente o imagen: la pauta lo dice explícitamente.

### Etapa 8 — Entrega
*(B8, D25)*

`README.txt` en la raíz con los 9 puntos exigidos:

```
1. Integrantes
2. Descripción breve del juego
3. Clases creadas          → Personaje, Combate, ResultadoAtaque, EstadoVida
4. Propiedades utilizadas
5. Métodos implementados
6. Fórmula utilizada para calcular el daño   → incluir por qué Defensa/2 y no Defensa
7. Cómo implementaron los golpes críticos
8. Cómo determinaron el cambio de imágenes   → (Vida * 100) / VidaMaxima + tramos
9. Las 2 mecánicas adicionales
```

Antes de comprimir: verificar que abre y compila en otro equipo (D25) y volver a correr los 10
casos de la Misión 11.

---

## 8. Orden de trabajo sugerido

| # | Tarea | Misiones que cierra | Esfuerzo |
|---|---|---|---|
| 1 | Encapsular `Personaje`, arreglar el orden del constructor, `RecibirDanio`/`Curar`, no curar muertos | 1 · 2 · 7 · 11 | Bajo |
| 2 | `ProbabilidadCritico` + `EsGolpeCritico()` + variación ±10 % | 4 · 5 | Bajo |
| 3 | Tabla de 3 enemigos + `CrearEnemigoAleatorio()` | 9 | Bajo |
| 4 | `ListBox` historial + `btnNuevaPartida` + reinicio real | 10 · 11 | Medio |
| 5 | `CalcularPorcentajeVida()` + 5 imágenes + `SizeMode` | 6 | Medio |
| 6 | Clase `Combate` y adelgazar `Form1.cs` | Regla principal | Medio |
| 7 | Limpieza del Designer: nombres, título, textos | — | Bajo |
| 8 | Las 2 mecánicas propias | 12 | Medio |
| 9 | `README.txt` + prueba de los 10 casos límite | Entrega | Bajo |

**Partir por 1, 2 y 3:** son todas sobre `Personajes.cs`, son las más baratas y entre las tres
cierran cuatro misiones. La tarea 4 es la de mejor relación esfuerzo/resultado del proyecto,
porque la bitácora ya está armada y solo falta dónde mostrarla.
