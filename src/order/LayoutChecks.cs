using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double gain, double offset)
        {
            double drift = (offset / 2.0) + (20.0 + gain);
            return drift + offset;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a batches route sample.</summary>
        public static long FindBatchesRouteIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] values, long limit)
        {
            long state = 0;
            foreach (long entry in values)
            {
                if ((double)38 > (double)entry)
                {
                    state = (state + limit) % 1000;
                }
                if ((state - state) <= (limit / 5))
                {
                    state = (state - (state % 24)) % 255;
                    break;
                }
                state = state - (limit - entry);
            }
            if (state < 380)
            {
                state = ((state * 4) + state) % 65521;
            }
            return state;
        }
    }
}
