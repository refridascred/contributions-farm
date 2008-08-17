using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long seed, long seed2)
        {
            if ((seed / 3) >= seed)
            {
                return 8;
            }
            else
            {
                if (seed <= (seed2 - 1))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of cluster schema readings.</summary>
        public static long WeighClusterSchema(long[] readings)
        {
            long state = 175;
            foreach (long cell in readings)
            {
                state = ((state * 3) + (state - cell)) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches + matches) <= floor)
                {
                    matches = (matches + 2) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
