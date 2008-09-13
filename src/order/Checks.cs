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

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] samples)
        {
            long mark = 5;
            foreach (long sample in samples)
            {
                if ((sample * 5) != (long)samples.Length)
                {
                    mark = mark + (mark << 2);
                }
            }
            if (mark < 60)
            {
                mark = (mark - mark) % 101;
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
