using DuckGame;

namespace SandwichSimulator.src {
    [EditorGroup("Stuff|Ingredients")]
    class Cucamber : Holdable, Ingredient {
        public Cucamber(float xval, float yval) : base(xval, yval) {
            graphic = new Sprite(GetPath("cucamber"));
            _holdOffset = new Vec2(-8f, -8f);
            editorOffset = new Vec2(-8f, -8f);
            collisionOffset = new Vec2(4f, 4f);
            collisionSize = new Vec2(8f, 8f);
            _editorName = "Cucamber";
            editorTooltip = "Why did the cucamber cross the road? No really, I miss you Johny.";
        }

        public Sprite GetSandwichSprite() {
            return new Sprite(GetPath("sandwich/cucamber"));
        }
    }
}
