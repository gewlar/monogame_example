# MonoGame Example

An example repository for the setup of a MonoGame project with [Facepunch.Steamworks](https://github.com/Facepunch/Facepunch.Steamworks).

## Development
This guide assumes you are using VSCode.

Install the dotnet-mgcb editor
```shell
dotnet tool restore
```
Add the following extensions to VSCode:
- C# Dev Kit
- MonoGame Content Builder (Editor)

Open `Content/Content.mgcb` in the MGCB Editor and run Build. You need to rebuild in the MGCB Editor whenever the assets change.

Now you can run the game with the Debug task or by pressing `F5`


## Build
You can use [GameBundle](https://github.com/Ellpeck/GameBundle) to produce builds for Windows, Linux and Mac

```bash
# Windows & Linux
gamebundle -wl -z --mg

# OSX
gamebundle -m -b --mg --nbeauty2
```