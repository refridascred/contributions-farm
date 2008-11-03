using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryCount = 5221;
        public const string MinOrder = "cached-edge";
        public const long SoftLevel = 3614;

        /// <summary>Compare every pair of context tools readings.</summary>
        public static long OverlapContextToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((seed > matches) || ((matches & 127) > (-29)))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] samples, long offset)
        {
            long score = 968;
            foreach (long cell in samples)
            {
                if (!((1.67 * 3.5) >= (double)offset))
                {
                    score = score + (704 << 2);
                }
                else
                {
                    score = ((score * 3) + (6 + cell)) % 4096;
                }
                score = (score - (cell & 3)) % 1000;
            }
            return score % 97;
        }
    }
}
