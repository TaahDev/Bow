
# 🏹 Bow

A functional bow with procedural string for unity.

![Alt Text](https://media.giphy.com/media/yRQE5hyZBTP5ntobNh/giphy-downsized-large.gif)

## ✨ Features

- Procedural string using a line renderer
- Dynamic projectile strength depending on the draw time
- Easy to set up


## 📍 Setup

- Add the `Bow` & `Arrow` scripts into your project.
- Drag the `Bow` script onto your bow and the Arrow script onto your arrow prefab.

> **Note**: The `Arrow` script is solely for the rotation of the arrow. If you want to use your own script, remove all the `Arrow` references in the `Bow` script.


- Setup everything in the unity editor.
### 🗒️ Properties:
- `MinStrength`: The minimum force applied to the Projectile.
- `MaxStrength`: The maximum force applied to the Projectile.
- `DrawTime`: The time in seconds until the bow reaches full strength.
- `DrawBackStrength`: The strength of which the string will be pulled back (Visual)
- `ProjectilePrefab`: Projectile Prefab
- `ProjectilePoint`: The position at which the Projectile is being spawned
- `ArrowRotation`: Default rotation of the arrow
- `FpCam`: Your first person camera
- `Upper, Middle & Lower Line`: Points for the line renderer.
- `Line Renderer`: Line Renderer of the Bow

### ⚠️ Important!

**Make sure you disable "Use World Space" option in your line renderer!**

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## 📄 License

This project is dedicated to the public domain under the CC0 1.0 Universal (CC0 1.0) Public Domain Dedication. For more information, see the [LICENSE](LICENSE) file or visit [CC0 Legal Code](https://creativecommons.org/publicdomain/zero/1.0/legalcode).
