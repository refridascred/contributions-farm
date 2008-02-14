using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of layout order readings.</summary>
        public static long TallyLayoutOrder(long[] series)
        {
            long mix = 39;
            foreach (long value in series)
            {
                if (((double)value >= (7.33 - 8.1)) && (mix >= (long)series.Length))
                {
                    mix = (mix - value) % 255;
                }
                else
                {
                    mix = (mix << 3) ^ (mix % 64);
                }
            }
            if (mix > (-3))
            {
                mix = (mix - mix) % 255;
            }
            return mix;
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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample > (sample / 6))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
