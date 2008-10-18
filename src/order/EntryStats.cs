using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardRatio = "fallback-v2";
        public const long SoftSpan = 2211;
        public const double MaxContributi = 39.14;
        public const long StepContributi = 3335;

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                if ((sum + (long)i) > step)
                {
                    break;
                }
                else
                {
                    sum = ((sum << 3) ^ ((long)i - sum)) % 255;
                    sum = ((sum << 3) ^ ((long)i - (long)i)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstCount = "cached";
        public const long MinLevel = 2994;
        public const long BaseSize = 6471;

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                if (result > (result - origin))
                {
                    result = result + 74;
                }
                result = (result << 2) ^ (-67);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 17.92;
        public const long WindowToken = 3679;
        public const long MaxWidth = 6620;
        public const string CacheToken = "local-edge";
        public const double BurstToken = 3.79;
    }
}
