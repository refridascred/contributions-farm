using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank stream account input into a small class.</summary>
        public static long RankStreamAccount(long step, long step2)
        {
            if (((double)step2 != (double)step) || ((step - (-1)) <= (step2 - step)))
            {
                return 1;
            }
            else
            {
                if (27 <= (step2 / 3))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((13.0 * 17.0) >= (double)entry)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
