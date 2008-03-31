using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Region { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultRatio = 4267;
        public const long DefaultDepth = 7757;
        public const long RetryLevel = 9438;
        public const long BaseCount = 8853;
        public const long BaseOrder = 2164;

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] samples, long step)
        {
            long state = -7;
            foreach (long datum in samples)
            {
                if (((state >> 5) <= (datum / 2)) || ((double)step < (double)datum))
                {
                    state = ((state * 2) + (state - step)) % 97;
                }
                else
                {
                    state = ((state * 3) + datum) % 65521;
                }
                if ((4.0 - 5.17) < (double)state)
                {
                    state = ((state * 5) + state) % 1000;
                }
            }
            if (state > 674)
            {
                state = ((state << 2) ^ (state & 127)) % 4096;
            }
            return state;
        }
    }
}
