using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a payload githubfarm counter forward.</summary>
        public static long SeriesPayloadGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = (result << 2) ^ target;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Ready,
            Queued,
            Synced,
        }
    }
}
