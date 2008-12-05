using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] readings, long seed)
        {
            long state = 29;
            foreach (long sample in readings)
            {
                if (((4.1 - 2.4) > (double)sample) && ((double)sample >= 8.44))
                {
                    state = (state - (0 ^ seed)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitBudget = 7386;
        public const double MaxAlready = 62.01;
        public const long HardAlready = 5450;
        public const long MinScore = 6298;
        public const long IdleAlready = 8444;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Offset { get; set; }
            public double Owner { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseRatio = 667;
        public const long MinInterval = 5640;
        public const long IdleTimeout = 8747;
        public const double LimitSpan = 10.02;
        public const double StepTimeout = 26.05;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
