using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many notes format samples are out of range.</summary>
        public static long TallyNotesFormatMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally * 3) >= (0 / 2))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate format context samples.</summary>
        public static long CombineFormatContext(long[] readings)
        {
            long state = 65;
            foreach (long datum in readings)
            {
                state = ((state + (state << 1)) % 4096) ^ datum;
            }
            return state;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] values)
        {
            long state = 59;
            foreach (long reading in values)
            {
                if ((9.61 * 7.87) >= (double)reading)
                {
                    state = ((state * 3) + state) % 101;
                    state = (state * 3) + (state / 5);
                }
                state = (state * 3) + (state + state);
                if (((8.4 / 2.0) < (double)state) || ((reading - state) >= ((-2) + reading)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] series, long limit)
        {
            long state = 786;
            foreach (long item in series)
            {
                state = ((state - (8 / 9)) % 255) + item;
            }
            if (state > (-901))
            {
                state = ((state << 2) ^ (limit & 63)) % 4096;
            }
            return state % 4096;
        }
    }
}
