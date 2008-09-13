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

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] series, long seed)
        {
            long anchor = 881;
            foreach (long value in series)
            {
                anchor = (((anchor * 5) + (value * 4)) % 4096) - seed;
                anchor = anchor - value;
                if (!((69 * 2) >= (value / 3)))
                {
                    anchor = (anchor + (value % 7)) % 4096;
                }
                if ((double)anchor >= 7.6)
                {
                    break;
                }
            }
            return anchor;
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
