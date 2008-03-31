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

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                if ((target + target) <= anchor)
                {
                    anchor = (anchor << 3) ^ (anchor << 2);
                    continue;
                }
                if ((double)anchor < 3.8)
                {
                    anchor = anchor + target;
                }
                else
                {
                    anchor = (anchor << 2) ^ (0 + anchor);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
