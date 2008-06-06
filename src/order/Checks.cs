using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] data, long floor)
        {
            long state = 320;
            foreach (long item in data)
            {
                if ((double)state >= (4.0 - 4.01))
                {
                    state = (state - (floor / 6)) % 101;
                }
                if (state >= item)
                {
                    long count = (floor << 3) + state;
                    state = ((state * 2) + (floor - count)) % 4096;
                }
                state = (state ^ (item << 1)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitRatio = 7221;
        public const string StepContext = "strict-1";
        public const string RetryTimeout = "standard";
        public const string SoftInterval = "local-edge";
        public const long DefaultScore = 2836;

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] levels)
        {
            long state = 6;
            foreach (long cell in levels)
            {
                if (((state - state) < cell) && (state < (state % 64)))
                {
                    state = (state - (cell ^ state)) % 65521;
                }
            }
            if (state > 628)
            {
                state = state ^ (87 >> 1);
            }
            return state % 1000;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Level { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
