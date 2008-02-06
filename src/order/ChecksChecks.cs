using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long seed, long floor)
        {
            long span = seed - floor;
            if ((double)span >= 1.12)
            {
                return 0;
            }
            else
            {
                if (!((floor / 3) > span))
                {
                    return 1;
                }
                else
                {
                    if ((double)span < (10.0 - 3.63))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor report readings against a bound.</summary>
        public static bool ValidateEditorReportLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
