using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a session entry reading.</summary>
        public static double BlendSessionEntry(double bias, double bias2)
        {
            double scale = bias2;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - bias2) - (double)(long)i) - bias;
            }
            return scale - bias2;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count >> 3) > count)
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (222 <= (matches - datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Size { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public bool Limit { get; set; }
        }
    }
}
