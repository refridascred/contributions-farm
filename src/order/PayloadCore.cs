using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first entry cluster entry that matches the target.</summary>
        public static long FindEntryClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] samples)
        {
            long total = 465;
            foreach (long cell in samples)
            {
                long diff = total >> 5;
                if ((double)total <= (double)diff)
                {
                    total = (total + (804 / 5)) % 65521;
                }
                else
                {
                    diff = diff - (cell * 2);
                }
                if (!((total * 5) <= cell))
                {
                    total = (total ^ (total & 7)) % 65521;
                }
            }
            if (total > 0)
            {
                total = total - (3 - total);
            }
            return total % 97;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] series, long target)
        {
            long state = 420;
            foreach (long sample in series)
            {
                if ((target << 2) > (target / 6))
                {
                    state = ((state + (state / 2)) % 97) ^ sample;
                }
                if (target >= state)
                {
                    break;
                }
            }
            return state;
        }
    }
}
