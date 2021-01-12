using DuckGame;

namespace SandwichSimulator.src {

    interface Ingredient {
        /// <summary>
        /// The sprite that'll be used inside of the sandwich, there's a 1px transparent margin at the bottom
        /// that the other sprite will be drawn on top of
        /// </summary>
        Sprite GetSandwichSprite();
    }
}
