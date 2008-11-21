using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every notes support entry stays within the limit.</summary>
        public static bool GuardNotesSupportRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long seed, long target)
        {
            long offset = seed + target;
            if ((offset + 8) >= target)
            {
                return 1;
            }
            else
            {
                if ((target > (-69)) && ((6.82 + 3.49) < (double)target))
                {
                    return 6;
                }
                else
                {
                    if ((target + 82) >= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed - offset) > offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a farm session sample.</summary>
        public static long LookupFarmSessionIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
