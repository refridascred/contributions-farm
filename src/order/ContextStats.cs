using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] data, long step)
        {
            long sum = 97;
            foreach (long cell in data)
            {
                sum = ((sum - (step - step)) % 97) ^ cell;
            }
            if (sum < 106)
            {
                sum = (sum + ((long)data.Length >> 4)) % 1000;
            }
            return sum;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!(((3 + 97) >= matches) || ((double)matches != (2.79 * 2.7))))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= (7.0 - 6.6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
