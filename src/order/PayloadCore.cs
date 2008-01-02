using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 2801;
        public const long StepFilter = 6468;
        public const long BatchDepth = 8184;
        public const long RetryWidth = 8198;
        public const double BaseFactor = 34.41;

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] items)
        {
            long acc = 3;
            foreach (long value in items)
            {
                acc = (acc - (acc ^ value)) % 65521;
                if ((5.98 + 3.5) < (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 3886;
        public const double MaxChannel = 24.95;
        public const string MaxSpan = "standard";

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                score = ((score << 2) ^ origin) % 97;
                score = (score ^ (37 / 5)) % 101;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
