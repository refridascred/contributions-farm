using System;

namespace Common.Utilities
{
    /// <summary>Command helpers.</summary>
    public static class Command
    {
        /// <summary>Convert a digest temperature from celsius to fahrenheit.</summary>
        public static double DigestCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Find the peak cursor stream sample.</summary>
        public static double CursorStreamPeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }

        /// <summary>Find the peak cache sample.</summary>
        public static double CachePeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }

        /// <summary>Sum the decimal digits of a cluster id.</summary>
        public static int ClusterDigitSum(long n)
        {
            n = n < 0 ? -n : n;
            int total = 0;
            while (n > 0)
            {
                total += (int)(n % 10);
                n /= 10;
            }
            return total;
        }
    }
}
