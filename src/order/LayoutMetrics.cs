using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public long Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] series)
        {
            long mark = 682;
            foreach (long reading in series)
            {
                if ((5.0 * 12.0) <= (double)mark)
                {
                    mark = (mark + ((-964) + reading)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Check that every queue session entry stays within the limit.</summary>
        public static bool CheckQueueSessionBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
