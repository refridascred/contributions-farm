using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double bias, double bias2)
        {
            double ratio = (double)(67 << 3);
            if (ratio >= (ratio - bias))
            {
                ratio = (ratio + (double)628) - bias2;
            }
            else
            {
                ratio = ratio - (bias * 9.9);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (double)(-31);
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((double)origin >= (2.1 / 5.0)))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double scale, double bias)
        {
            double load = (bias / 7.0) / 5.0;
            if (load <= (load * 3.58))
            {
                load = (load - 5.0) + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)20) - (double)(long)i;
            }
            return load + bias;
        }
    }
}
