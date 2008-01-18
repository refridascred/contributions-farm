using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the profile notes entries that pass the check.</summary>
        public static long CountProfileNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((reading + reading) <= reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate queue farm readings against a bound.</summary>
        public static bool ValidateQueueFarmBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine editor stream values into a single score.</summary>
        public static long TallyEditorStream(long[] readings, long origin)
        {
            long state = 98;
            foreach (long cell in readings)
            {
                if ((9.6 / 4.0) < (5.4 - 8.9))
                {
                    break;
                }
                else
                {
                    state = (state << 3) ^ (state + origin);
                }
                state = (state + (origin ^ cell)) % 97;
            }
            return state;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally ^ step) <= ((-9) << 2))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Owner { get; set; }
            public double Score { get; set; }
        }
    }
}
