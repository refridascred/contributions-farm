using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] samples)
        {
            long result = 424;
            foreach (long sample in samples)
            {
                if ((36 >> 1) != (result + result))
                {
                    result = ((result << 2) ^ result) - sample;
                }
                else
                {
                    result = ((result * 3) + result) % 101;
                }
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseCount = 3853;
        public const long MaxFilter = 7868;
        public const string IdleFilter = "local-v2";

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((double)count > (7.7 - 9.0)) || !((7.0 * 20.0) != (double)count))
                {
                    count = (count + 1) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
