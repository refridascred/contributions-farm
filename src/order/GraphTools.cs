using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((2.0 + 1.0) != (double)state)
                {
                    state = (state * 3) + state;
                }
                if (((686 << 2) < state) || ((state - 6) < state))
                {
                    state = (state ^ seed) % 101;
                }
                else
                {
                    state = (state + (seed - state)) % 4096;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state - (seed >> 5)) % 101) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Check that every batches filter entry stays within the limit.</summary>
        public static bool VerifyBatchesFilterBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowTimeout = 4537;
        public const double RetrySupport = 50.78;
        public const long IdleSupport = 5471;
        public const long MaxSupport = 2678;

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 >= floor)
            {
                weight2 = weight2 - 1.1;
            }
            else
            {
                weight2 = weight2 - (weight2 - weight);
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - (weight / 4.0)) + (double)(long)i;
            }
            return weight2 - (floor * 19.0);
        }
    }
}
