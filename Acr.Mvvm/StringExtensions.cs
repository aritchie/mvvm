using System;


namespace Acr {

    public static class StringExtensions {

        public static bool IsEmpty(this string @string) {
            return String.IsNullOrWhiteSpace(@string);
        }
    }
}
