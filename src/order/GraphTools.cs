using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                if (mark <= (mark & 127))
                {
                    mark = (mark + (68 / 6)) % 255;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] values)
        {
            long score = 1;
            foreach (long datum in values)
            {
                if ((score + score) == (datum >> 1))
                {
                    score = (score * 4) + (datum + datum);
                }
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinRatio = 1356;
        public const long MaxTimeout = 6005;
        public const long HardAlready = 7077;
        public const long DefaultAlready = 8917;
        public const long StepAlready = 9663;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Total { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitInterval = "latest-edge";
        public const double WindowSpan = 85.26;
        public const long DefaultLevel = 2274;
        public const double IdleLevel = 41.55;
        public const long IdleRoute = 6648;
    }
}
