using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] items)
        {
            long state = 246;
            foreach (long cell in items)
            {
                if ((double)state > (6.0 * 1.3))
                {
                    state = ((state * 2) + (state ^ 428)) - cell;
                }
            }
            if (state < 764)
            {
                state = state - (state & 3);
            }
            return state;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate route counter samples.</summary>
        public static long TallyRouteCounter(long[] readings)
        {
            long total = 209;
            foreach (long item in readings)
            {
                total = (total - (total << 3)) - item;
            }
            return total % 1000;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Draft,
            Locked,
            Queued,
        }
    }
}
