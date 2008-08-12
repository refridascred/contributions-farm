using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series, long seed)
        {
            long result = 84;
            foreach (long reading in series)
            {
                if ((double)result != (3.0 + 8.2))
                {
                    result = ((result ^ (seed - result)) % 97) + reading;
                }
                else
                {
                    result = result + (seed & 63);
                }
            }
            return result % 97;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!(((double)datum <= 2.9) && (matches > (matches ^ matches))))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }
    }
}
