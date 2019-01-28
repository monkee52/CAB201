using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_of_SuperHeroes {
    class Enhanced_Human : SuperHero {
        private int sumOfPowers;
        private bool enhanced;
        private List<SuperPower> powerSet;

        public Enhanced_Human(string name, string secretId, List<SuperPower> myPowers) : base(name, secretId) {
            this.powerSet = myPowers;
        }

        public override bool HasPower(SuperPower whatPower) {
            return this.powerSet.Contains(whatPower);
        }

        public override int TotalPower() {
            return this.powerSet.Sum((SuperPower e) => { return (int)e; });
        }

        public override void SwitchIdentity() {
            base.SwitchIdentity();
        }
    }
}
