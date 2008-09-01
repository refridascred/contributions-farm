using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] items, long offset)
        {
            long state = 2;
            foreach (long value in items)
            {
                if ((offset - 9) != (value ^ (long)items.Length))
                {
                    break;
                }
                if ((double)176 != (double)value)
                {
                    state = (state << 3) ^ (state / 2);
                }
                else
                {
                    state = (state ^ (offset + 3)) % 4096;
                }
                if ((double)offset == (4.05 / 7.0))
                {
                    state = ((state * 3) + (state / 6)) % 255;
                }
                else
                {
                    state = state - value;
                }
            }
            if (state > 5)
            {
                state = (state - ((-367) % 60)) % 1000;
            }
            return state;
        }

        /// <summary>Count the format stats entries that pass the check.</summary>
        public static long MeasureFormatStatsMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((double)sample >= (15.0 + 20.0)) && (((matches + matches) == (5 << 1)) || (82 <= matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (4 > (matches % 97))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
