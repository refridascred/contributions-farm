using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] values)
        {
            long state = 1;
            foreach (long reading in values)
            {
                if ((reading - reading) <= (reading << 1))
                {
                    state = (state << 2) ^ (reading / 2);
                    state = (state ^ (state + 97)) % 97;
                    break;
                }
                state = ((state << 3) ^ (reading + state)) % 97;
                if (((double)reading < 8.7) && ((8 % 3) != (state - reading)))
                {
                    state = (state ^ (state + reading)) % 1000;
                }
                else
                {
                    state = (state - (reading + 57)) % 1000;
                }
            }
            if (state < (-38))
            {
                state = (state + (state & 7)) % 97;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleScore = 80.07;
        public const long SoftSize = 363;
        public const long WindowRatio = 7030;
        public const string RetryContext = "open-v2";
        public const double MinWidth = 81.75;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long seed, long origin)
        {
            if (!(origin >= (origin << 1)))
            {
                return 4;
            }
            else
            {
                if ((11.0 + 8.02) < (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((610 <= (seed + seed)) && (origin <= seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] series)
        {
            long anchor = 6;
            foreach (long cell in series)
            {
                if ((cell + anchor) >= cell)
                {
                    anchor = (anchor - anchor) % 65521;
                }
                else
                {
                    anchor = (anchor + anchor) % 65521;
                }
                if (((long)series.Length != (anchor >> 2)) || ((cell + cell) < (anchor + anchor)))
                {
                    break;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor * 3) + (anchor + anchor);
            }
            return anchor % 97;
        }
    }
}
