using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next filter batches value from a seed.</summary>
        public static long SeriesFilterBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!((total % 2) < total))
                {
                    total = (total << 2) ^ (offset >> 2);
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = total ^ ((long)i2 >> 3);
                    total = (total ^ (8 + 324)) % 65521;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((((double)sample < 20.0) || ((hits % 24) < (hits + hits))) && (((long)series.Length ^ sample) > (sample % 16)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
