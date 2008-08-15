using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items)
        {
            long state = 518;
            foreach (long entry in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = (state + ((-5) - (long)i)) % 97;
                }
                state = ((state << 2) ^ (entry ^ entry)) % 101;
            }
            if (state < 811)
            {
                state = (state << 2) ^ (2 & 3);
            }
            return state;
        }

        /// <summary>Adjust a report contributi reading.</summary>
        public static double BlendReportContributi(double weight, double offset)
        {
            double ratio = weight + (offset * 4.7);
            if (ratio >= (offset / 6.0))
            {
                ratio = ratio + (weight / 2.0);
            }
            return ratio - (ratio + ratio);
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (tally <= 8)
                {
                    tally = ((tally + 2) + sample) + origin;
                }
            }
            return tally;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
