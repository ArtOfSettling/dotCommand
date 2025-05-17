# .Command

![Unity Command Line Tool](https://dotcommand-documentation.readthedocs.io/en/latest/_images/suggestions.svg)

A powerful runtime command console and in-game inspector for Unity. It works across all platforms and brings advanced debugging and tooling features directly into your live game builds.

## Key Features

- **In-Game Log Viewer**  
  View and search your Unity logs while the game is running, without digging into log files — works in Editor and Player builds.

- **Runtime GameObject Inspector**  
  Explore active GameObjects and their components, fields, and properties live on any platform — including mobile and console.

- **Smart Commands & Auto-Complete**  
  Annotate C# methods and properties with attributes to generate interactive console buttons. Supports autocomplete, nested paths, and parameterized calls.

- **Email Logs from Device**  
  Instantly export and email logs or callstacks from any platform — perfect for remote testing and QA workflows.

---

## Getting Started

1. Grab the latest release from the [GitHub Releases Page](https://github.com/ArtOfSettling/dotCommand/releases).
2. Import the unity package into your unity project.
3. Drag the WellFired/WellFired.Command/Platform/Prefabs/DebugConsoleLoader.prefab into any scene and you are done!

Read more on how to use .command
1. [Programmatic Instantiation](https://dotcommand-documentation.readthedocs.io/en/latest/learn/step_by_step/quick_start.html)
2. [Exposing Custom Commands](https://dotcommand-documentation.readthedocs.io/en/latest/learn/step_by_step/custom_commands.html#introduction)
3. [Adding Custom Log Levels](https://dotcommand-documentation.readthedocs.io/en/latest/learn/step_by_step/logs_and_filters.html#introduction)
4. [Built in commands](https://dotcommand-documentation.readthedocs.io/en/latest/learn/step_by_step/built_in_commands.html)

---

## Dev Environment Setup

If you're contributing or building the Unity package yourself, follow these steps:

### Prerequisites

- Unity (6.1 LTS or newer recommended)
- Node.js (we recommend using [nvm](https://github.com/nvm-sh/nvm) to install)

```bash
nvm install --lts
nvm use --lts
```

### Install Build Tools

Install Jake (task runner) and CoffeeScript compiler:

```bash
npm install -g jake coffeescript
```

> **Note:** Global install is required for CLI commands like `jake` to work in terminal.

### Verify Setup

Run the following to list available tasks:

```bash
jake -T
```

To build the Unity `.unitypackage` export:

```bash
jake unity:export-package -c
```

This will print a message like:

```
[INFO] Using unity path: /Applications/Unity/Hub/Editor/...
```

The built `.unitypackage` will be located under the `unity/` directory.

---

## Using the Unity Project

You can also just open the Unity project located at `/unity/` in the Unity Hub to explore or test the package in action.

---

## Input System Compatibility

.Command supports toggling the in-game console with the backquote key (`` ` ``). If you're using Unity's **new Input System**, make sure to:

---

## Documentation

Full usage docs and API reference are available at:  
📖 [https://dotcommand-documentation.readthedocs.io/en/latest/](https://dotcommand-documentation.readthedocs.io/en/latest/)
