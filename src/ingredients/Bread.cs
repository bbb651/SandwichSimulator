using DuckGame;

namespace SandwichSimulator.src {
    [EditorGroup("Stuff|Ingredients")]
    class Bread : Holdable, Ingredient {
        public Bread(float xval, float yval) : base(xval, yval) {
            graphic = new Sprite(GetPath("bread"));
            _holdOffset = new Vec2(-8f, -8f);
            editorOffset = new Vec2(-8f, -8f);
            collisionOffset = new Vec2(4f, 4f);
            collisionSize = new Vec2(8f, 8f);
            _editorName = "Bread";
            editorTooltip = "Pita sucks right? Bread is way better.";
        }

        public Sprite GetSandwichSprite() {
            return new Sprite(GetPath("sandwich/bottom"));
        }
    }
}
