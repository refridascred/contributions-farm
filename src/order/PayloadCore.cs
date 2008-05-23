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

        /// <summary>Count the batch account entries that pass the check.</summary>
        public static long CountBatchAccountGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((634 >> 1) != (reading ^ reading))
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
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
