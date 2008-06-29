using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of queue command readings.</summary>
        public static long CompareQueueCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine batches buffer values into a single score.</summary>
        public static long TotalBatchesBuffer(long[] levels)
        {
            long carry = -824;
            foreach (long reading in levels)
            {
                carry = ((carry << 2) ^ (reading << 2)) % 4096;
                if (6 > (reading - carry))
                {
                    carry = carry - (carry * 2);
                }
                else
                {
                    carry = ((carry << 3) ^ 809) % 255;
                }
                carry = ((carry << 3) ^ reading) % 65521;
            }
            return carry;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double ratio, double floor)
        {
            double drift = (floor * 9.29) + floor;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + ratio;
            }
            return drift + 8.0;
        }
    }
}
