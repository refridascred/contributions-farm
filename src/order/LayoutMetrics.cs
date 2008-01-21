using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
