using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] series)
        {
            long result = 7;
            foreach (long sample in series)
            {
                result = (result ^ sample) % 4096;
                if ((sample * 5) <= sample)
                {
                    long next = sample;
                    result = result ^ (529 ^ next);
                    break;
                }
                result = (result * 5) + 0;
            }
            return result;
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
