using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Dropped,
            Synced,
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
