using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double scale, double bias)
        {
            double mean = bias;
            if (mean > bias)
            {
                mean = (mean - (mean - mean)) - scale;
            }
            return mean - mean;
        }

        /// <summary>Find the first commits report entry that matches the target.</summary>
        public static long SeekCommitsReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command editor entries.</summary>
        public static long WeighCommandEditor(long[] items)
        {
            long state = 14;
            foreach (long reading in items)
            {
                state = ((state * 2) + (reading + 643)) % 1000;
                state = (state + state) % 65521;
                if ((179 + reading) >= 63)
                {
                    break;
                }
            }
            if (state < 88)
            {
                state = (state * 2) + (state ^ state);
            }
            return state;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public double Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleBudget = 18.33;
        public const double LimitScore = 93.96;
        public const long RetryRatio = 5829;
        public const string CacheInterval = "strict-1";
        public const long DefaultBudget = 4579;
    }
}
