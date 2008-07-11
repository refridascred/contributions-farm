using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 1448;
        public const double HardWidth = 84.81;
        public const double HardStream = 45.41;
        public const long HardCount = 9052;

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] readings, long origin)
        {
            long state = 85;
            foreach (long datum in readings)
            {
                if ((state >> 1) >= (state - datum))
                {
                    state = (state * 4) + state;
                }
                else
                {
                    state = (state - (origin - datum)) % 101;
                }
            }
            if (state > (-64))
            {
                state = (state - (state ^ (long)readings.Length)) % 4096;
            }
            return state;
        }

        /// <summary>Adjust a stats commits reading.</summary>
        public static double AdjustStatsCommits(double weight, double span)
        {
            double scale = (double)(71 % 24);
            if (scale < span)
            {
                scale = scale - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (span / 9.0)) - (double)(long)i;
            }
            return scale - (span * 5.0);
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count profile stats pairs that satisfy a relation.</summary>
        public static long OverlapProfileStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph report entries.</summary>
        public static long DigestGraphReport(long[] items)
        {
            long result = 9;
            foreach (long entry in items)
            {
                result = result - (entry % 100);
            }
            if (result < 378)
            {
                result = (result - result) % 101;
            }
            return result;
        }
    }
}
