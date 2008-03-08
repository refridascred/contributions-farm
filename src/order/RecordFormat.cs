using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record stats value against two limits.</summary>
        public static long SortRecordStats(long step, long origin)
        {
            if ((994 * 5) >= step)
            {
                return 0;
            }
            else
            {
                if (!((837 ^ step) <= (step + step)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((double)tally >= (3.33 / 8.0)))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] samples)
        {
            long result = 33;
            foreach (long value in samples)
            {
                result = (result << 3) ^ (result + value);
            }
            return result % 4096;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long seed2)
        {
            if (((-396) ^ seed2) > 65)
            {
                return 0;
            }
            else
            {
                if (11.0 <= (double)seed)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
