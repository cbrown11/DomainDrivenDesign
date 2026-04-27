# Domain Driven Design (DDD)
This library gives a template and interfaces for Domain Drive Design.

CQRS can be used without event sourcing or DDD, just as these concepts work without CQRS. However there is no denying that three concepts complement each other.

So this library gives a template to implement a DDD pattern using the Event Sourcing pattern, which can be implemented with a CQRS pattern. With this pattern, application state is stored as sequence of events. Each event represents a set of changes to the data. The current state is constructed by replaying the events

![alt text](https://www.codeproject.com/KB/architecture/555855/CQRS.jpg)

Reference: This is a re-implementation of Greg Young's [SimpleCQRS](https://github.com/gregoryyoung/m-r) project, arguably the de-facto sample application for CQRS, DDD & Event Sourcing.

## NuGet: `Cbrown11.Common.Models` (GitHub Packages)

This repo consumes **`Cbrown11.Common.Models`** from **`https://nuget.pkg.github.com/cbrown11/index.json`** (see `nuget.config`). That feed is not anonymous: restores must be authenticated.

- **Locally:** use a GitHub [personal access token](https://github.com/settings/tokens) with **`read:packages`** (and **`repo`** if the package or source repo is private), then configure NuGet for the `github-cbrown11` source (for example `dotnet nuget update source github-cbrown11 --username cbrown11 --password <PAT> --store-password-in-clear-text`). Details: [Working with the NuGet registry](https://docs.github.com/en/packages/working-with-a-github-packages-registry/working-with-the-nuget-registry).

  Do **not** use `dotnet restore --configfile ..\nuget.config` for everyday local restores: `--configfile` tells NuGet to use **only** that file, so your PAT in `%AppData%\NuGet\NuGet.Config` is ignored and GitHub Packages returns **401**. From the repo root, run `dotnet restore DomainDrivenDesign.sln` (or `dotnet restore` under `src` **without** `--configfile`) so the repo `nuget.config` is merged with your user config and credentials apply.

- **GitHub Actions:** the default `GITHUB_TOKEN` cannot read packages published from another repository. CI uses repository secret **`GH_PACKAGES_READ_TOKEN`** (same PAT scope) with `actions/setup-dotnet` `source-url` / `NUGET_AUTH_TOKEN` in the workflows.

## Publishing this library (Git tag)

The [Publish package](.github/workflows/publish-package.yml) workflow runs when a tag matching `v*` is pushed. Example for version **1.0.1**:

```bash
git tag v1.0.1
git push origin v1.0.1
```
