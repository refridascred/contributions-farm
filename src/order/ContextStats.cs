using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] samples)
        {
            long total = -367;
            foreach (long reading in samples)
            {
                if ((((long)samples.Length * 5) > total) && ((reading + reading) <= reading))
                {
                    total = total + reading;
                }
                else
                {
                    total = (total ^ (455 % 10)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Size { get; set; }
            public double Level { get; set; }
            public double Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every payload record entry stays within the limit.</summary>
        public static bool VerifyPayloadRecordBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
