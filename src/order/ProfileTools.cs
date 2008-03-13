using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double scale, double span)
        {
            double load = (double)(-291) / 4.0;
            if (load <= (scale * 7.67))
            {
                load = load - (span - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (span - span)) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Measure how many entry queue samples are out of range.</summary>
        public static long AuditEntryQueueGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)sample <= (double)seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate batches checks readings against a bound.</summary>
        public static bool ValidateBatchesChecksLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
