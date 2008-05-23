using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Synced,
            Draft,
            New,
        }

        /// <summary>Validate support schema readings against a bound.</summary>
        public static bool ValidateSupportSchemaLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((1.0 / 9.0) <= (double)value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the layout buffer series from a seed.</summary>
        public static long SeriesLayoutBuffer(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                mark = mark + (736 + floor);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
