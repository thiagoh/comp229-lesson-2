using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace comp229_lesson_2.Models {

    public class TestMe {

        public static String stringLabel = "meu valor";

        public static String getRandomValue() {
            return new Random().Next(0, 1000).ToString();
        }
    }

}