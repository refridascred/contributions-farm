using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a already editor sample.</summary>
        public static long FindAlreadyEditorIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long step, long target)
        {
            if ((step ^ step) <= (target - target))
            {
                return 5;
            }
            else
            {
                if ((705 - target) <= (step / 8))
                {
                    return 4;
                }
                else
                {
                    if ((step < (2 >> 4)) || ((step << 1) >= (step & 63)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2.44 * 5.0) <= (double)step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
