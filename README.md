# Cat Server A branche for DanhengServer

**__This project is building! The game cannot run correctly!__**

<p align="center">
<a href="https://visualstudio.com"><img src="https://img.shields.io/badge/Visual%20Studio-000000.svg?style=for-the-badge&logo=visual-studio&logoColor=white" /></a>
<a href="https://dotnet.microsoft.com/"><img src="https://img.shields.io/badge/.NET-000000.svg?style=for-the-badge&logo=.NET&logoColor=white" /></a>
<a href="https://www.gnu.org/"><img src="https://img.shields.io/badge/GNU-000000.svg?style=for-the-badge&logo=GNU&logoColor=white" /></a>
</p>
<p align="center">
  <a href="https://discord.gg/xRtZsmHBVj"><img src="https://img.shields.io/badge/Discord%20Server-000000.svg?style=for-the-badge&logo=Discord&logoColor=white" /></a>
</p>

[EN](README.md) | [JP](docs/README_ja-JP.md)

## 💡 Function

- [√] **Shop**
- [√] **Formation**
- [√] **Gacha** - Custom Probability: )
- [√] **Battle** - There are some errors in the scene skills
- [√] **Scene** - Walking simulator, interaction, correct loading of entities
- [√] **Basic character development** - Some minor bugs that don't significantly affect the experience
- [√] **Quests** - Many quests involving the male protagonist have been completed. If you choose the female protagonist, you may get stuck in certain quests and need to be repaired
- [√] **Friends** - There are many bugs and under development
- [√] **Simulated Universe** - There are many bugs and under development

- [ ] **More**  - Comming soon

## 🍗 Use & Installation

### Quick Start

1. Download the executable file from [Action](https://github.com/Luotianyi-0712/CatServer/actions)
2. Open the downloaded `DanhengServer.zip` and extract it to any folder __*preferably an English path__
   (Optional) Download the `certificate.p12` from the WebServer folder of the source code to enable HTTPS mode, ensuring a more secure transmission
3. Run GameServer.exe
4. Run the agent, start the game link, and enjoy!

### Build

Danheng server is built using Dotnet

- Download the executable file in [Action](https://github.com/StopWuyu/DanhengServer/actions) or build it by urself
- Unzip it to a single folder
- Download the Dim's Resources and LunarCore's Resources.Do it as well as LunarCore
- Download the file in Config folder in this repo(Preparing),And move the files to Config/ folder
- Run it.

**Requirement: **

- [.NET](https://dotnet.microsoft.com/)
- [Git](https://git-scm.com/downloads)

##### Windows

```shell
git clone --recurse-submodules https://github.com/Luotianyi-0712/CatServer.git
cd DanhengServer
dotnet build # compile
```

## ❓ Help

- Support Android system
- Mission 100040119 (cannot be completed automatically) (use /mission finish 100040119 to fix it)

## ❕️ Troubleshooting

For solutions to common problems or assistance, please join our Discord server at [https://discord.gg/xRtZsmHBVj](https://discord.gg/xRtZsmHBVj)

## 🙌 Thank you

- Weedwacker - provides kcp implementation
- [SqlSugar](https://github.com/donet5/SqlSugar) - Provides ORM
- [LunarCore](https://github.com/Melledy/LunarCore) - Some data structures and algorithms
