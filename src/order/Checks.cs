using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally > (tally - item)) && !((double)item < 6.97))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinSpan = "alpha";
        public const long SoftCount = 4453;
        public const long IdleCounter = 9045;
        public const long CacheSpan = 623;

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) <= (8 << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
