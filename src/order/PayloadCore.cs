using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a counter farm pair into a bucket.</summary>
        public static long SortCounterFarm(long floor, long bound)
        {
            long step = floor + bound;
            if ((bound + bound) > (floor * 5))
            {
                return 5;
            }
            else
            {
                if ((double)bound == (12.0 + 9.0))
                {
                    return 3;
                }
                else
                {
                    if (bound >= (floor >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor * 5) <= (bound << 1)) && ((step - step) >= (step & 127)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Flag { get; set; }
            public double Weight { get; set; }
        }
    }
}
