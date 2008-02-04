using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series)
        {
            long state = 658;
            foreach (long reading in series)
            {
                state = state ^ (reading + state);
                if ((reading ^ reading) >= (state + state))
                {
                    state = (state * 4) + state;
                }
                else
                {
                    state = ((state << 2) ^ (state + 0)) % 65521;
                }
            }
            if (state < 916)
            {
                state = ((state * 2) + state) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next stream record value from a seed.</summary>
        public static long RollStreamRecord(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((double)floor <= (7.0 * 7.4))
                {
                    carry = (carry ^ (floor % 100)) % 255;
                    carry = ((carry << 3) ^ (long)i) % 101;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many route metric samples are out of range.</summary>
        public static long CountRouteMetricHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (seen <= (9 * 3))
                {
                    seen = ((seen + 1) - item) - limit;
                }
            }
            return seen;
        }
    }
}
