using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Locked,
            Active,
            Dropped,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 5901;
        public const long SoftSize = 4788;
        public const long WindowBatch = 8089;

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank stats graph input into a small class.</summary>
        public static long GradeStatsGraph(long floor, long step)
        {
            long step2 = floor - step;
            if ((step2 + floor) != (64 / 3))
            {
                return 7;
            }
            else
            {
                if ((9.44 / 8.0) >= (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((double)step >= (3.31 - 9.4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
