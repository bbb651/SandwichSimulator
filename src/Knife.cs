using DuckGame;
using System.Collections.Generic;
using System.Linq;

namespace SandwichSimulator.src {
    [EditorGroup("Guns|Melee")]
    class Knife : Sword {
        public Knife(float xval, float yval) : base(xval, yval) {
            graphic = new Sprite(GetPath("knife"));
            _editorName = "Knife";
            editorTooltip = "The ultimate sandwich maker. Oh and did I mention it kills ducks?";
        }

        public override void Fire() {
            base.Fire();
            IEnumerable<Ingredient> ingredients = Level.CheckCircleAll<Ingredient>(position, 40f);
            if (ingredients.Any(x => x is Bread) && ingredients.Count() > 1) {
                Level.Add(new Sandwich(position.x, position.y, ingredients));
                foreach (Ingredient ingredient in ingredients) {
                    Level.Remove((Thing)ingredient);
                }
            }
        }
    }
}
