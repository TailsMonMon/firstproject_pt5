using System;

namespace firstproject_pt5 {
    class animal {
        public string name;
        public string sound;

        public animal() {
            name="no name";
            sound="quiet";
        }
        
        /*      Different way to write the same thing.
        public animal(string name = "no name", string sound = "quiet") {
            this.name=name;
            this.sound=sound;
        }
        */

    }
}
