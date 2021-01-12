using DuckGame;

namespace SandwichSimulator.src {
    [EditorGroup("Stuff|Ingredients")]
    class Tomato : Holdable, Ingredient {
        public Tomato(float xval, float yval) : base(xval, yval) {
            graphic = new Sprite(GetPath("tomato"));
            _holdOffset = new Vec2(-8f, -8f);
            editorOffset = new Vec2(-8f, -8f);
            collisionOffset = new Vec2(4f, 4f);
            collisionSize = new Vec2(8f, 8f);
            _editorName = "Tomato";
            editorTooltip = "Help! I'm being eaten alive by a sworm of ducks god no!!!".ToUpper();
        }

        public Sprite GetSandwichSprite() {
            return new Sprite(GetPath("sandwich/tomato"));
        }
    }
}
