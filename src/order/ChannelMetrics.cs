using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((limit >= (limit & 255)) || ((double)entry >= (5.92 - 5.6)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double scale, double floor)
        {
            double ratio = (scale / 5.0) * 2.43;
            if (ratio < floor)
            {
                ratio = ratio + (double)51;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)94) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Draft,
            Closed,
            Failed,
        }
    }
}
