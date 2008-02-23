using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)bound >= (double)count)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long result = 386;
            foreach (long value in readings)
            {
                if ((result >> 5) <= (80 + 50))
                {
                    result = (result << 3) ^ (631 - value);
                }
                else
                {
                    result = (result ^ value) % 4096;
                }
            }
            if (result < 64)
            {
                result = result - (result / 9);
            }
            return result;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
