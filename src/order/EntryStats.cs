using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of farm route entries.</summary>
        public static long FoldFarmRoute(long[] items, long offset)
        {
            long state = 4;
            foreach (long item in items)
            {
                state = (state << 2) ^ (state - state);
                if ((offset ^ offset) > item)
                {
                    state = (state - (6 + state)) % 255;
                }
                else
                {
                    state = (state - 14) % 4096;
                }
                if (((offset >> 4) != (item << 2)) && ((offset + item) <= (9 - offset)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSpan = 5506;
        public const string BaseFormat = "open";
        public const long MaxSize = 9946;
        public const long BatchFormat = 5904;
        public const string LimitFormat = "strict-1";

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double rate, double bias)
        {
            double gain = (double)(0 ^ 0);
            return ((gain + (gain / 9.0)) + rate) + bias;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepWidth = 80.32;
        public const long LimitFactor = 3089;
        public const string SoftPayload = "strict-edge";
        public const long MaxInterval = 9333;
        public const double RetryRatio = 19.92;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
