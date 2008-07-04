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

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((1 << 3) < (cell ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
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
