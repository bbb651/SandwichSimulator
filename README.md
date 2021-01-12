# Sandwich Simulator
### A duck game mod by bbb651

*Now with 78% more junk*

## Features
### Knife

Used to make sandwiches. Oh and also murder ducks

![Bread](content/knife.png)

*Try using it near bread and other ingredients*

### Ingredients
| Bread          | Cheese       | Cucamber     | Lettuce      | Tomato      |
| :------------- | :----------: | -----------: | -----------: | -----------: |
| ![Bread](content/bread.png)| ![Bread](content/cheese.png)| ![Bread](content/cucamber.png)| ![Bread](content/lettuce.png)| ![Bread](content/tomato.png)
## Adding ingredient support to your mod
*Note: Please don't do this, I thought it would be a cool feature but it's currently really useless*

This mod can support registering custom ingredients from other mods.
* Register the mod as a depedency
```xml
<Mod>
    <HardDependencies>sandwich_simulator</HardDependencies>
</Mod>
```
* Add the `Ingredient` attribute along with the sprite that will appear in the sandwich to each class you want to be an ingredient
```c#
[(new Sprite(GetPath("sandwich/vinegar")))]
class Vinegar : Gun, Ingredient {
    
    public Sprite GetSandwichSprite() {
        return new Sprite(GetPath("sandwich/vinegar"));
    }

    [...]
}
```
* You can also add sandwich effects if you want to for some reason
```c#
Sandwich.AddEffect(delegate(Sandwich dave) {
    // Gives dave a 9 inch duck
    dave.duck.scale = new Vec2(9f, 9f);
});
```
(yes, I have the `{` on the same line fight me)

## Support
If you have any questions about duck game or modding duck game, join the [Duck Game Discord Server](https://discord.gg/24tWqDQ).

If you have any bug reports/questions/suggestion, open an issue in the repo, and if you need to contact me directly my discord is `bbb651#3370`.