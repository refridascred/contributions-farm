using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheChannel = 88.46;
        public const string LimitChannel = "alpha-edge";
        public const long MaxFactor = 2837;
        public const long BatchChannel = 8055;

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double weight, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean + 6.0) + (double)(long)i) - weight;
            }
            return mean - floor;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Size { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] items)
        {
            long result = 682;
            foreach (long entry in items)
            {
                result = ((result - 38) % 97) - entry;
            }
            return result;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
