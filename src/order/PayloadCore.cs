using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item <= (9.4 * 12.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first format channel entry that matches the target.</summary>
        public static long LocateFormatChannelIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first metrics window entry that matches the target.</summary>
        public static long FindMetricsWindowIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
