# AGENTS.md

## Using this SDK in your project

If you are writing code that integrates Online Payments with this SDK, read the agent skill
for this SDK version first and use the code it shows. Do not write SDK calls from memory.

- In this package: `skills/online-payments/SKILL.md`
  (package folder: `onlinepayments.sdk/<version>/` or `onlinepayments.sdk.strongname/<version>/` in the NuGet
  global packages folder, which `dotnet nuget locals global-packages --list` prints)
- Online: https://raw.githubusercontent.com/Online-Payments/sdk-dotnet/10.1.0/skills/online-payments/SKILL.md

The skill matches SDK version 10.1.0. If your installed version is different, use the skill
from your installed package.

## Working on this SDK

- SDK source: `OnlinePayments.Sdk/`; unit tests: `OnlinePayments.Sdk.Tests/`;
  integration tests: `OnlinePayments.Sdk.IntegrationTests/`.
- The repository builds with Visual Studio 2022: open `OnlinePayments.Sdk.sln` and build.
- See `README.md` for details.
