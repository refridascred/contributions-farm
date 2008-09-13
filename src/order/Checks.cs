using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseLevel = 21.55;
        public const long DefaultScore = 7808;
        public const string MaxRoute = "legacy";
        public const long BaseFactor = 5738;
        public const long WindowRoute = 7415;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                long count = mark + mark;
                if ((count % 64) >= (count + 7))
                {
                    mark = (mark + (6 >> 5)) % 255;
                    break;
                }
                if ((count & 3) < ((long)i + mark))
                {
                    count = (count + ((long)i - 985)) % 1000;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 57.62;
        public const long MaxCache = 6544;
        public const string WindowDepth = "stable-1";
        public const string HardSize = "stable-edge";

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] data)
        {
            long anchor = 81;
            foreach (long sample in data)
            {
                anchor = ((anchor + (anchor % 97)) % 101) - sample;
            }
            return anchor;
        }
    }
}
