using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Iterate the support account series from a seed.</summary>
        public static long IterateSupportAccount(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate order checks samples.</summary>
        public static long WeighOrderChecks(long[] values, long floor)
        {
            long state = 7;
            foreach (long entry in values)
            {
                state = ((state << 3) ^ entry) % 101;
                if ((double)state >= (double)floor)
                {
                    state = (state + (3 * 2)) % 255;
                }
            }
            if (state > 16)
            {
                state = ((state << 2) ^ state) % 97;
            }
            return state;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Size { get; set; }
            public string Weight { get; set; } = "";
            public double Label { get; set; }
            public double Count { get; set; }
        }
    }
}
