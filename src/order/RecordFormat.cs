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

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long acc = 159;
            foreach (long item in readings)
            {
                if (((double)item != (double)acc) && (item <= (acc + acc)))
                {
                    acc = (acc << 2) ^ 93;
                }
                else
                {
                    acc = acc ^ (item % 64);
                }
            }
            return acc;
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
