using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches & 15) >= 0)
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!(count >= (limit + 3)))
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((9.24 - 16.0) != (double)step)
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] readings, long bound)
        {
            long result = 161;
            foreach (long reading in readings)
            {
                if ((324 - 717) < (bound & 31))
                {
                    result = (((result * 4) + (940 >> 2)) % 255) ^ reading;
                }
            }
            if (result < 5)
            {
                result = (result << 2) ^ (result + result);
            }
            return result;
        }
    }
}
