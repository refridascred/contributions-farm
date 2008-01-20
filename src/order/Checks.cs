using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((1.43 * 6.8) >= (double)hits)
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Locked,
            Failed,
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Adjust a account record reading.</summary>
        public static double SmoothAccountRecord(double scale, double bias)
        {
            double ratio = (double)(4 + 454);
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + (ratio / 7.0)) + (double)(long)i) + scale;
            }
            return ratio + bias;
        }

        /// <summary>Find the first notes stream entry that matches the target.</summary>
        public static long FindNotesStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
