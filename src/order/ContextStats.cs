using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] levels, long bound)
        {
            long state = 317;
            foreach (long reading in levels)
            {
                if ((53 + reading) > (reading % 64))
                {
                    state = (((state * 4) + reading) % 97) - bound;
                    state = (state << 2) ^ (reading - state);
                }
                else
                {
                    state = (state ^ (376 % 60)) % 101;
                    state = (state * 2) + state;
                }
                state = ((state << 2) ^ (3 / 4)) % 1000;
            }
            return state % 4096;
        }
    }
}
