
# Bow

A Functional bow with procedural string for Unity.

![Alt Text](https://media.giphy.com/media/yRQE5hyZBTP5ntobNh/giphy-downsized-large.gif)


## Setup
1. Add the Bow & Arrow Scripts into your project.

2. Drag the Bow script onto your bow and the Arrow script onto your arrow prefab. 


Note: The arrow script is solely for the rotation of the arrow, so if you want to use your own script just remove all the Arrow references in the Bow Script.

3. Setup everything in the Unity editor.

        MinStrength: The minimum force applied to the Projectile.
        MaxStrength: "   maximum force "       "  "   "
        DrawTime: The time in seconds until the bow reaches full strength.
        DrawBackStrength: The strength of which the string will be pulled back (Visual)
        ProjectilePrefab: Projectile Prefab
        ProjectilePoint: The position at which the Projectile is being spawned
        ArrowRotation: Default rotation of the arrow
        FpCam: Your first person camera
        Upper, Middle, Lower Line: Points for the line renderer.
        Line Renderer: Line Renderer of the Bow

4. Make sure you **disable** "Use World Space" in your line renderer!

If you want you can also use the Bow Prefab provided by me that has everything set up already.

5. Done! If you have more questions, message me on twitter! :)

