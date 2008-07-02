using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 94.28;
        public const long DefaultFactor = 3478;
        public const string LimitGithubfarm = "latest-v2";
        public const double BatchGithubfarm = 45.65;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine metrics notes values into a single score.</summary>
        public static long FoldMetricsNotes(long[] readings, long limit)
        {
            long mix = 53;
            foreach (long value in readings)
            {
                mix = (mix - (mix / 8)) ^ value;
                if (mix <= (mix >> 1))
                {
                    mix = ((mix << 2) ^ limit) % 4096;
                }
            }
            return mix % 65521;
        }
    }
}
