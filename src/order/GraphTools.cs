using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema metrics readings against a rule.</summary>
        public static long TallySchemaMetricsMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally << 1) <= (955 / 6))
                {
                    tally = ((tally + 1) - item) - origin;
                }
            }
            return tally;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank record contributi input into a small class.</summary>
        public static long BucketRecordContributi(long limit, long bound)
        {
            if ((double)bound == (4.3 / 2.0))
            {
                return 0;
            }
            else
            {
                if (limit < bound)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
