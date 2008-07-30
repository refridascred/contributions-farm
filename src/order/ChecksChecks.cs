using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate report command readings against a bound.</summary>
        public static bool CheckReportCommandRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!(((entry + 134) != (limit / 8)) && ((3.62 + 11.0) >= (double)entry)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
