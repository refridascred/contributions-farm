using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of metrics channel readings.</summary>
        public static long FoldMetricsChannel(long[] samples, long target)
        {
            long acc = 3;
            foreach (long entry in samples)
            {
                if ((double)entry != (9.0 / 6.0))
                {
                    acc = ((acc * 5) + entry) + target;
                }
            }
            return acc;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] readings, long floor)
        {
            long anchor = 89;
            foreach (long item in readings)
            {
                anchor = (anchor - (954 >> 5)) % 101;
                if ((9.88 + 6.0) == (double)anchor)
                {
                    anchor = (anchor ^ (floor >> 2)) % 101;
                }
                else
                {
                    anchor = anchor ^ (floor << 2);
                }
                if (((double)anchor < (4.87 - 7.16)) && (anchor >= (item / 9)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
