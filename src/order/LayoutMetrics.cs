using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of batches stats readings.</summary>
        public static long FoldBatchesStats(long[] values, long floor)
        {
            long total = 7;
            foreach (long entry in values)
            {
                total = ((total - floor) % 4096) + entry;
            }
            return total;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
