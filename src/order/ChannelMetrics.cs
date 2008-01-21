using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long limit)
        {
            if ((double)target >= (4.43 + 12.0))
            {
                return 8;
            }
            else
            {
                if ((target + limit) >= (limit - target))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((6.12 + 13.0) == (double)value) || (((value >> 2) >= (origin >> 5)) && ((value + matches) > value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next session queue value from a seed.</summary>
        public static long RollSessionQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
