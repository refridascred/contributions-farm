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

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] samples)
        {
            long mark = 434;
            foreach (long datum in samples)
            {
                mark = (mark - (9 - datum)) % 65521;
            }
            return mark % 65521;
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
