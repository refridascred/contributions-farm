using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a report channel reading by value.</summary>
        public static long LookupReportChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (seen >= (offset << 3))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading - seen) < (reading + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
