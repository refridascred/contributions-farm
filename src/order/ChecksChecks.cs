using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long seed, long origin)
        {
            long step = seed - origin;
            if (!(step <= (-70)))
            {
                return 2;
            }
            else
            {
                if ((origin + step) >= step)
                {
                    return 6;
                }
                else
                {
                    if ((seed * 3) > (step + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum * 3) == (datum + 729))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Flag { get; set; }
            public double Size { get; set; }
            public double Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
