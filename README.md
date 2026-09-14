# ShaderSpace

ShaderSpace is a lightweight Unity Editor extension that gives Unity Shader Graph a larger, focused workspace.

Shader Graph can become cramped when working with nodes and connections alongside the rest of the Unity Editor layout. ShaderSpace lets you quickly maximize the opened Shader Graph window and restore the original layout when you're done.

> **Status:** Early Alpha — v0.1

## Preview

### Normal Unity workspace

![Before](docs/images/before.png)

### ShaderSpace

![After](docs/images/after.png)

## Features

- Detects the currently opened Shader Graph window
- Maximizes Shader Graph into a focused workspace
- Restores the original Unity Editor layout
- Simple toggle from the Unity Editor menu
- No modification to your Shader Graph assets

## Usage

1. Open a Shader Graph in Unity.
2. From the Unity menu, select:

   `Window > ShaderSpace > Toggle Workspace`

3. Shader Graph will expand into a maximized workspace.
4. Run the command again to restore the previous Unity Editor layout.

## Installation

### Manual installation

For the current alpha version:

1. Download or clone this repository.
2. Copy:

   `Assets/ShaderSpace`

   into the `Assets` folder of your Unity project.

3. Let Unity compile the Editor extension.

ShaderSpace will then appear under:

`Window > ShaderSpace`

> Unity Package Manager installation is planned for a future release.

## Requirements

- Unity 6
- Shader Graph

ShaderSpace is currently in early development and has only been tested in a limited development environment.

## Roadmap

Planned features include:

- Focus Mode
- Hide Blackboard, Graph Inspector, and Main Preview
- Restore previous Shader Graph panel states
- Connection highlighting
- Connected-node navigation
- Improved workspace controls
- Unity Package Manager support

## Known Limitations

- A Shader Graph window must already be open
- The current version focuses only on workspace maximization
- Floating Shader Graph windows may behave differently from docked windows
- Compatibility with different Unity and Shader Graph versions has not yet been fully tested

## Contributing

ShaderSpace is currently in early development.

Bug reports, ideas, and feedback are welcome through GitHub Issues.

## License

ShaderSpace is licensed under the MIT License.

See [LICENSE](LICENSE) for details.