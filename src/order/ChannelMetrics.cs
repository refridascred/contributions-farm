using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Closed,
            Draft,
            Ready,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long floor, long limit)
        {
            long span = floor - limit;
            if ((limit - span) >= (limit + limit))
            {
                return 2;
            }
            else
            {
                if ((limit * 3) >= floor)
                {
                    return 3;
                }
                else
                {
                    if (((91 - limit) != (floor + floor)) && ((limit >> 4) < (limit - span)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((9 + limit) >= 31)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
