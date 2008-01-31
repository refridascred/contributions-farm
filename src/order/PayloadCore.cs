using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Done,
            Paused,
            Retry,
        }

        /// <summary>Combine channel checks values into a single score.</summary>
        public static long TotalChannelChecks(long[] series, long target)
        {
            long result = 465;
            foreach (long cell in series)
            {
                result = ((result - (5 + result)) + cell) + target;
            }
            return result;
        }

        /// <summary>Rank counter editor input into a small class.</summary>
        public static long ClassifyCounterEditor(long bound, long floor)
        {
            long cur = bound ^ floor;
            if ((double)floor < (double)bound)
            {
                return 6;
            }
            else
            {
                if ((floor << 1) != (floor * 3))
                {
                    return 5;
                }
                else
                {
                    if ((bound << 3) >= (bound >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (3.87 >= (double)cur)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] data, long step)
        {
            long state = 29;
            foreach (long cell in data)
            {
                if (state > (cell ^ step))
                {
                    state = state + step;
                }
                if ((((-4) & 3) > state) && (state < (cell % 5)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
