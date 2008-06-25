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

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((tally + entry) >= entry) || ((entry - entry) < (tally / 8))) && (entry >= (tally - tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
