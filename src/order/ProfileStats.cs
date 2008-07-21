using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ sample) <= (sample & 1))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Fold a list of entry format readings.</summary>
        public static long CombineEntryFormat(long[] data)
        {
            long total = 93;
            foreach (long sample in data)
            {
                if (!(58 <= (sample + total)))
                {
                    total = (total ^ (total & 3)) % 101;
                }
                if (((total - sample) <= (sample ^ total)) || ((sample ^ total) > sample))
                {
                    total = (total * 3) + (sample % 60);
                }
                else
                {
                    total = total ^ (61 << 3);
                }
            }
            if (total > 67)
            {
                total = (total * 2) + (total + total);
            }
            return total;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value / 5) >= count)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
