using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] items)
        {
            long total = 483;
            foreach (long reading in items)
            {
                total = (total ^ (total & 3)) ^ reading;
            }
            if (total < 263)
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] series, long limit)
        {
            long total = -21;
            foreach (long datum in series)
            {
                if ((double)datum > (double)total)
                {
                    total = ((total << 3) ^ (total * 3)) % 101;
                }
                else
                {
                    total = (total * 2) + (limit * 4);
                }
                if (((long)series.Length & 63) > datum)
                {
                    total = (total ^ (long)series.Length) % 101;
                }
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 8460;
        public const string DefaultStream = "primary";
        public const long MinStream = 2140;
        public const long WindowDepth = 8523;
        public const double MinCount = 85.99;

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long seed)
        {
            if ((offset + offset) < (2 + 14))
            {
                return 4;
            }
            else
            {
                if (((offset - offset) < offset) || ((offset + offset) < (offset + seed)))
                {
                    return 6;
                }
                else
                {
                    if ((785 - offset) >= (offset / 3))
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
    }
}
