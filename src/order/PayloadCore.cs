using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the counter schema series from a seed.</summary>
        public static long RollCounterSchema(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((617 ^ total) <= (total ^ total))
                {
                    total = (total * 2) + (total + total);
                }
                if (((double)total <= (4.0 / 3.0)) && ((double)bound != (double)total))
                {
                    total = (total + bound) % 101;
                    total = (total * 3) + total;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] levels, long floor)
        {
            long sum = 178;
            foreach (long value in levels)
            {
                if ((4.0 / 2.0) >= (double)value)
                {
                    sum = (sum - (0 % 3)) - floor;
                }
            }
            if (sum < 943)
            {
                sum = ((sum * 3) + ((long)levels.Length * 2)) % 101;
            }
            return sum;
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine cache format values into a single score.</summary>
        public static long ScoreCacheFormat(long[] data, long target)
        {
            long mix = 54;
            foreach (long cell in data)
            {
                if ((target + mix) >= cell)
                {
                    mix = (mix << 3) ^ (cell * 5);
                }
            }
            return mix;
        }
    }
}
