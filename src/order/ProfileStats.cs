using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ matches) >= sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long limit, long origin)
        {
            if ((limit ^ limit) <= origin)
            {
                return 3;
            }
            else
            {
                if ((962 ^ origin) < limit)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the report filter entries that pass the check.</summary>
        public static long AuditReportFilterHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (seen >= (seen & 31))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
