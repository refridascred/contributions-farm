using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            New,
            Closed,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long limit, long step)
        {
            if (0.4 >= (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit ^ (-701)) == (limit / 8))
                {
                    return 2;
                }
                else
                {
                    if (!((538 + step) > (step - step)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)step > (double)limit) || ((step - limit) == (limit / 7)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
