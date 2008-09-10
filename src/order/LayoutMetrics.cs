using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches % 12) < (item << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] data)
        {
            long total = -82;
            foreach (long value in data)
            {
                if ((total - value) <= ((long)data.Length / 3))
                {
                    total = ((total * 3) + (total >> 4)) % 4096;
                }
            }
            if (total > 937)
            {
                total = (total ^ total) % 101;
            }
            return total % 1000;
        }
    }
}
