using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first format buffer entry that matches the target.</summary>
        public static long LookupFormatBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((79 - value) <= (value % 60))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Locked,
            Paused,
        }
    }
}
