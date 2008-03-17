using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 3) ^ step) % 101;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Classify a metric farm pair into a bucket.</summary>
        public static long SortMetricFarm(long offset, long target)
        {
            if ((double)offset > (17.0 * 5.18))
            {
                return 5;
            }
            else
            {
                if (target > (19 % 97))
                {
                    return 7;
                }
                else
                {
                    if ((double)target != (19.0 + 8.55))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset / 8) <= (offset % 5)) && (target <= offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((floor + item) == (item - 861)) || (item < (tally >> 2))) || ((item < tally) && (3.12 > (double)floor)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
