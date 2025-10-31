# Unity Starter Helpers (example files)

These are helper/example files to get you started with a Unity project hosted on GitHub and automated WebGL builds.
**This is NOT a complete Unity project.** It's a small template containing:

- example C# script (Assets/Scripts/PlayerController.cs)
- example GitHub Actions workflow to build WebGL using GameCI (GameCI's unity-builder)
- .gitignore for Unity
- minimal Packages/manifest.json example

Use these steps:
1. Create a Unity project on your machine (Unity Editor).
2. Copy your project's `Assets/`, `ProjectSettings/`, and `Packages/` folders into a Git repo.
3. Add the files from this starter into that repo (they won't replace your real files).
4. Push to GitHub and configure GitHub Actions secrets (see the workflow).
5. Optionally connect the repo to Unity Cloud Build or use GitHub Actions to build WebGL.

Helpful links:
- Unity Cloud Build / Build Automation docs: https://docs.unity.com/ (search "Cloud Build" or "Build Automation").
- GameCI (unity-builder) docs: https://game.ci/docs/github/builder/
- Example auto WebGL repo: https://github.com/NikkiAsteinza/Unity-WebGL-Automatic-build-and-deployment

--- Notes ---
- To build a Unity project in CI you must provide a Unity license or use an editor image that includes the Unity Editor.
- Unity Cloud Build may require a Teams subscription for some features.
- If you need, I can help adapt the workflow to your license type (personal/professional/Unity Teams).
