using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every session stream entry stays within the limit.</summary>
        public static bool CheckSessionStreamBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the notes cluster entries that pass the check.</summary>
        public static long MeasureNotesClusterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Size { get; set; }
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
