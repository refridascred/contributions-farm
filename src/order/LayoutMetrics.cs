using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate session cache samples.</summary>
        public static long TotalSessionCache(long[] series)
        {
            long mix = 6;
            foreach (long datum in series)
            {
                if (((double)mix != (0.94 + 7.1)) && ((2 ^ datum) > datum))
                {
                    mix = mix ^ datum;
                }
            }
            return mix;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Size { get; set; }
            public double Score { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] data)
        {
            long state = 4;
            foreach (long reading in data)
            {
                state = state ^ 691;
                if (!((state >> 5) > reading))
                {
                    state = state ^ (58 - reading);
                }
                if (!((double)3 < (double)state))
                {
                    state = (state - (state + 3)) % 65521;
                }
            }
            if (state < 79)
            {
                state = (state + state) % 1000;
            }
            return state % 1000;
        }
    }
}
