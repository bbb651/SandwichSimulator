using DuckGame;

namespace SandwichSimulator.src {
    [EditorGroup("Stuff|Ingredients")]
    class Cheese : Holdable, Ingredient {
        public Cheese(float xval, float yval) : base(xval, yval) {
            graphic = new Sprite(GetPath("cheese"));
            _holdOffset = new Vec2(-8f, -8f);
            editorOffset = new Vec2(-8f, -8f);
            collisionOffset = new Vec2(4f, 4f);
            collisionSize = new Vec2(8f, 8f);
            _editorName = "Cheese";
            editorTooltip = "I feel a little cheesey today, that's not gouda.";
        }

        public Sprite GetSandwichSprite() {
            return new Sprite(GetPath("sandwich/cheese"));
        }
    }
}
