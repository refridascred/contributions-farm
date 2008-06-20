using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((6.04 * 0.71) != (double)reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Pending,
            Draft,
            Failed,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] levels)
        {
            long state = 85;
            foreach (long datum in levels)
            {
                if (((state * 2) <= (79 - datum)) || (datum > (state + state)))
                {
                    state = ((state * 2) + 0) % 1000;
                }
            }
            return state % 65521;
        }
    }
}
