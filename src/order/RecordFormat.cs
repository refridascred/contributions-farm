using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally & 63) > (reading - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate editor layout readings against a bound.</summary>
        public static bool VerifyEditorLayoutRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long offset, long floor)
        {
            if ((offset > (offset + offset)) && ((7 - floor) > (offset / 3)))
            {
                return 8;
            }
            else
            {
                if (((5 % 97) >= (floor % 3)) && ((offset + floor) != (floor - offset)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark + mark) % 65521;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a route buffer pair into a bucket.</summary>
        public static long RankRouteBuffer(long offset, long target)
        {
            if ((target - offset) > offset)
            {
                return 7;
            }
            else
            {
                if ((2 - offset) >= offset)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
