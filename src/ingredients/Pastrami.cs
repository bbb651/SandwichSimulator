using DuckGame;

namespace SandwichSimulator.src {
    [EditorGroup("Stuff|Ingredients")]
    class Pastrami : Holdable, Ingredient {
        public Pastrami(float xval, float yval) : base(xval, yval) {
            graphic = new Sprite(GetPath("pastrami"));
            _holdOffset = new Vec2(-8f, -8f);
            editorOffset = new Vec2(-8f, -8f);
            collisionOffset = new Vec2(4f, 4f);
            collisionSize = new Vec2(8f, 8f);
            _editorName = "Pastrami";
            editorTooltip = "Pastrami, pastrayou, pastraus.";
        }

        public Sprite GetSandwichSprite() {
            return new Sprite(GetPath("sandwich/pastrami"));
        }
    }
}
