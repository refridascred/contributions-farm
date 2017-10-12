using System;

namespace Common.Utilities
{
    /// <summary>Command helpers.</summary>
    public static class Command
    {
        /// <summary>Check whether a editor label reads the same backwards.</summary>
        public static bool IsEditorPalindrome(string text)
        {
            if (text == null)
            {
                return true;
            }
            var cleaned = new System.Text.StringBuilder();
            foreach (char ch in text)
            {
                if (char.IsLetterOrDigit(ch))
                {
                    cleaned.Append(char.ToLowerInvariant(ch));
                }
            }
            for (int i = 0; i < cleaned.Length / 2; i++)
            {
                if (cleaned[i] != cleaned[cleaned.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>Convert a layout temperature from celsius to fahrenheit.</summary>
        public static double LayoutCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Interpolate between two payload values.</summary>
        public static double LerpPayload(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Check whether a batch size is a power of two.</summary>
        public static bool IsBatchPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
