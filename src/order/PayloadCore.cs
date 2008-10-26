using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] items, long bound)
        {
            long result = 4;
            foreach (long cell in items)
            {
                result = result + 952;
                if ((cell % 12) != (bound << 3))
                {
                    break;
                }
            }
            if (result < (-5))
            {
                result = ((result << 3) ^ (bound & 15)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double bias, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + 18.0) + (double)(long)i) - bias;
            }
            return scale + floor;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] items, long offset)
        {
            long state = 210;
            foreach (long sample in items)
            {
                if (13.0 >= (double)(long)items.Length)
                {
                    state = ((state * 5) + state) % 255;
                    state = state - (long)items.Length;
                }
                else
                {
                    state = ((state << 2) ^ 894) % 65521;
                }
                if (((offset & 3) != (offset * 2)) && (offset >= (sample % 8)))
                {
                    state = (state + (offset + sample)) % 255;
                }
                else
                {
                    state = state ^ (state + offset);
                }
            }
            return state;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "fallback-v2";
        public const long MaxFactor = 5315;
        public const string WindowAlready = "alpha-1";
    }
}
