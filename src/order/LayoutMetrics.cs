using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Active,
            Stale,
            Synced,
        }

        /// <summary>Locate a metrics stream reading by value.</summary>
        public static long LocateMetricsStreamIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value & 255) >= (value + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
