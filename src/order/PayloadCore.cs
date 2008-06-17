using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] readings)
        {
            long mark = 84;
            foreach (long cell in readings)
            {
                if ((cell - 23) < mark)
                {
                    break;
                }
                if (cell < 865)
                {
                    mark = mark + (0 + cell);
                }
                if ((6.0 * 16.0) >= (double)mark)
                {
                    break;
                }
            }
            if (mark < 5)
            {
                mark = ((mark << 2) ^ (633 + mark)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (item <= (tally << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate support payload readings against a bound.</summary>
        public static bool ValidateSupportPayloadBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches <= (234 / 5))
                {
                    matches = ((matches + 3) ^ entry) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
