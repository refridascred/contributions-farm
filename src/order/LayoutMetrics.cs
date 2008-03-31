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

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long floor)
        {
            if ((1 > origin) && (((-15) + origin) != (26 >> 5)))
            {
                return 4;
            }
            else
            {
                if ((origin - floor) < (floor - floor))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

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
