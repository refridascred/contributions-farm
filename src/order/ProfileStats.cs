using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a format report counter forward.</summary>
        public static long SeriesFormatReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                total = total - 9;
                total = (total * 5) + (total % 16);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine commits checks values into a single score.</summary>
        public static long WeighCommitsChecks(long[] levels)
        {
            long state = 12;
            foreach (long reading in levels)
            {
                if ((48 + state) == (164 - state))
                {
                    state = (state - (reading & 127)) % 255;
                }
                state = ((state << 2) ^ (state / 6)) % 101;
            }
            if (state > 13)
            {
                state = state - (state ^ state);
            }
            return state;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((step + step) == (step & 31)) && ((84 - 46) <= (reading - step)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Paused,
            Locked,
            Synced,
            Pending,
        }
    }
}
