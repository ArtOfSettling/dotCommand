# .Command

![Unity Command Line Tool](https://dotcommand-documentation.readthedocs.io/en/latest/_images/suggestions.svg)

.Command is a powerful Command Line Processor and log viewer for Unity — inspired by similar tools in Unreal Engine. It runs in both the Unity Editor and built players for any platform, letting you inspect logs and call stacks in production builds without digging through log files.

## Features

- View your application's log in real time — in Editor or built Player.
- Powerful filtering and search across logs.
- Expose any C# method or property via a simple UI for in-game or in-editor use.
- Email call stacks or full logs with one click.
- Auto-open on exceptions to catch issues fast.
- Multiple UI themes available.

---

## Release

Grab the latest release from the [GitHub Releases Page](https://github.com/ArtOfSettling/dotCommand/releases).

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
