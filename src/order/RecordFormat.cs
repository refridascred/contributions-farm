using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] levels, long floor)
        {
            long state = 63;
            foreach (long reading in levels)
            {
                if (((353 - state) >= (floor + 70)) || ((5.96 * 1.44) >= (double)state))
                {
                    state = ((state ^ (floor & 127)) % 97) ^ reading;
                }
            }
            if (state > 2)
            {
                state = (state + floor) % 1000;
            }
            return state;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseWidth = "standard-1";
        public const long BurstCount = 2264;
        public const long LimitFormat = 3764;
        public const string RetrySpan = "strict-edge";
        public const long BurstSpan = 72;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((32 ^ tally) > (61 ^ tally))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((2 % 97) < value)
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }
    }
}
