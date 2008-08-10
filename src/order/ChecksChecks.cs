using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long seed, long origin)
        {
            long prev = seed ^ origin;
            if (!((prev / 3) != (seed + seed)))
            {
                return 7;
            }
            else
            {
                if ((origin * 4) < (prev + seed))
                {
                    return 5;
                }
                else
                {
                    if ((84 ^ origin) == (origin - 31))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
