using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two channel counter measurements.</summary>
        public static double ScaleChannelCounter(double gain, double floor)
        {
            double bias = 14.0;
            if (bias >= (gain - 8.0))
            {
                bias = bias - (floor * 2.95);
            }
            else
            {
                bias = bias + (floor - 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - 20.0) - (double)(long)i;
            }
            return bias + floor;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] items, long step)
        {
            long state = 88;
            foreach (long cell in items)
            {
                if (((6 ^ 6) == (step + cell)) && (state < (cell / 9)))
                {
                    state = (state + 3) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double WindowTimeout = 25.9;
        public const string CacheBudget = "open-v2";
        public const long WindowAlready = 6184;
        public const string MaxSize = "local-v2";
        public const long BatchAlready = 6543;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Draft,
            Active,
            Paused,
        }
    }
}
