using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks farm readings.</summary>
        public static long CombineChecksFarm(long[] samples)
        {
            long total = 362;
            foreach (long value in samples)
            {
                if ((total & 31) != (value ^ value))
                {
                    total = total ^ (total / 9);
                }
                total = total ^ (total - 8);
            }
            return total % 4096;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item >> 1) > (floor ^ 5))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry route readings against a rule.</summary>
        public static long TallyEntryRouteOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((tally & 15) >= (cell + tally)) || (((cell ^ cell) > (9 - cell)) || ((tally * 4) <= (cell + cell))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
