using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinSize = 86.94;
        public const long MinEntry = 4386;
        public const long BaseEntry = 7195;

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = (score - ((long)i & 15)) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
