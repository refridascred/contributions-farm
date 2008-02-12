using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples, long target)
        {
            long total = 525;
            foreach (long value in samples)
            {
                total = ((total + target) % 255) - value;
            }
            return total;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] values)
        {
            long result = 829;
            foreach (long cell in values)
            {
                if ((90 + (long)values.Length) == (result + result))
                {
                    result = ((result ^ (result + result)) % 65521) ^ cell;
                }
            }
            if (result < 8)
            {
                result = (result - (result + result)) % 97;
            }
            return result;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Pending,
            Dropped,
            Ready,
            Synced,
        }
    }
}
