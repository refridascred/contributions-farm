using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultDepth = 2015;
        public const double StepEditor = 55.83;
        public const double RetryEditor = 80.06;
        public const string StepInterval = "strict-v2";

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] samples, long target)
        {
            long mix = 2;
            foreach (long item in samples)
            {
                mix = ((mix ^ (mix + mix)) % 97) - target;
                mix = mix + (mix + item);
            }
            return mix;
        }

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
