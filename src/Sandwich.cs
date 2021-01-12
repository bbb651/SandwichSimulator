using DuckGame;
using System;
using System.Collections.Generic;

namespace SandwichSimulator.src {

    [EditorGroup("Stuff")]
    class Sandwich : Holdable {

        private List<Sprite> _sprites;

        private static List<Action<Sandwich>> effects = new List<Action<Sandwich>> {
            delegate(Sandwich instance) {
                instance.duck.scale *= 1.25f;
            },
            delegate(Sandwich instance) {
                instance.duck.GoRagdoll();
            },
            delegate(Sandwich instance) {
                instance.duck.blendColor = new Color(145, 83, 204, 127);
            },
            delegate(Sandwich instance) {
                instance.duck.Burn(instance.position, instance);
            },
            delegate(Sandwich instance) {
                instance.duck.scale = new Vec2(instance.duck.scale.x, instance.duck.scale.y* 0.5f);
            },
            delegate(Sandwich instance) {
                instance.duck.accelerationMultiplier *= 2;
            },
            delegate(Sandwich instance) {
                VirtualShotgun shotgun = new VirtualShotgun(instance.position.x, instance.position.y);
                shotgun.infinite = true;
                Level.Add(shotgun);
                instance.duck.GiveHoldable(shotgun);
            },
            delegate(Sandwich instance) {
                instance.duck.dead = true;
            },
            delegate(Sandwich instance) {
                instance.duck.quackPitch *= 2;
            },
            delegate(Sandwich instance) {
                instance.duck._double = true;
            },
            delegate(Sandwich instance) {
                instance.duck.y -= 1000;
            },
            delegate(Sandwich instance) {
                instance.flipVertical = true;
            },
            delegate(Sandwich instance) {
                // Musical sandwich
                Music.Play("jazzroom");
            },
            delegate(Sandwich instance) {
                instance.scale = new Vec2(0.01f);
            },
            delegate(Sandwich instance) {
                Present present = new Present(instance.position.x, instance.position.y);
                Level.Add(present);
                instance.duck.GiveHoldable(present);
            },
            delegate(Sandwich instance) {
                instance.scale = new Vec2(100f, 100f);
            },
        };

        /// <summary>
        /// Adds a random effect to the pool of effects that can trigger when eating a sandwich
        /// </summary>
        /// <param name="effect">Callback that will be called when the sandwich is consumed and the event is choosen</param>
        public static void AddEffect(Action<Sandwich> effect) {
            effects.Add(effect);
        }

        public Sandwich(float xval, float yval, IEnumerable<Ingredient> ingredients = null) : base(xval, yval) {
            _sprites = new List<Sprite>();
            _sprites.Add(new Sprite(GetPath("sandwich/top")));
            // The editor will not provide ingredients so it'll be null, empty sandwich is exclusive to the editor
            if (ingredients != null) {
                foreach (Ingredient ingredient in ingredients) {
                    _sprites.Add(ingredient.GetSandwichSprite());
                }
            }
            _sprites.Add(new Sprite(GetPath("sandwich/bottom")));
            graphic = new Sprite();
            collisionOffset = new Vec2(4f, 4f);
            collisionSize = new Vec2(16f, 8f);
            _editorName = "Sandwich";
            editorTooltip = "Who eats an empty sandwich?";
        }

        public override void OnPressAction() {
            base.OnPressAction();
            // Invokes a random event and consumes the sandwich
            effects[Rando.Int(effects.Count - 1)].Invoke(this);
            Level.Remove(this);
        }

        public override void Draw() {
            Vec2 offset = new Vec2(-10f, -20f);
            foreach (Sprite s in _sprites) {
                base.Draw(s, offset);
                // Draws the next sprite on the bottom pixel of the last sprite, to give the abillity to have a transition
                offset.y += s.height - 1;
            }
        }
    }
}
