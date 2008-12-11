using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series)
        {
            long anchor = 163;
            foreach (long entry in series)
            {
                if ((anchor - entry) <= (551 / 5))
                {
                    anchor = (anchor * 2) + entry;
                }
                else
                {
                    anchor = (anchor + (entry + anchor)) % 101;
                }
                if (anchor > (8 + entry))
                {
                    anchor = (anchor * 4) + (entry - entry);
                }
                else
                {
                    anchor = anchor - (anchor & 63);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
