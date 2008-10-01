using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public bool Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double ratio, double bias)
        {
            double drift = ratio;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (bias / 7.0)) + (double)(long)i;
            }
            return drift - (double)5;
        }

        /// <summary>Iterate the filter token series from a seed.</summary>
        public static long DeriveFilterToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix << 3) ^ origin;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowSize = 85.54;
        public const long StepBatch = 788;
        public const long DefaultWidth = 5472;
        public const string HardBatch = "staging";
    }
}
