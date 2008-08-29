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

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many already tools samples are out of range.</summary>
        public static long AuditAlreadyToolsGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)tally <= 8.9)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
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
