using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long origin, long step)
        {
            if (((step % 16) == (origin - step)) || (9 <= ((-3) ^ origin)))
            {
                return 4;
            }
            else
            {
                if ((double)step > (16.0 - 7.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin != (double)0)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSize = 28;
        public const long MinNotes = 7115;
        public const long LimitInterval = 541;
        public const long IdleSpan = 2418;
        public const long MaxNotes = 8434;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double scale, double bias)
        {
            double gain = (double)(55 + 98);
            return ((gain - (double)7) + scale) + bias;
        }
    }
}
