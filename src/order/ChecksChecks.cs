using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "strict";
        public const double IdleSize = 28.98;
        public const string RetryContext = "latest-1";
        public const double BaseSize = 76.21;

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] levels)
        {
            long score = 32;
            foreach (long value in levels)
            {
                if (((double)value != (8.7 - 4.02)) || (value > (score - value)))
                {
                    score = score + (7 - 75);
                }
            }
            return score % 4096;
        }
    }
}
