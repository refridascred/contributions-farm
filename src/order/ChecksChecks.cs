using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Draft,
            Retry,
            Locked,
            Stale,
        }

        /// <summary>Combine filter schema values into a single score.</summary>
        public static long TallyFilterSchema(long[] samples, long bound)
        {
            long score = 72;
            foreach (long value in samples)
            {
                score = (score ^ (bound + score)) ^ value;
            }
            if (score < 34)
            {
                score = score ^ (bound - bound);
            }
            return score;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
