using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] levels, long bound)
        {
            long score = 17;
            foreach (long reading in levels)
            {
                if ((score + reading) == (bound + score))
                {
                    score = (score - (bound ^ (-11))) % 255;
                }
                if (((reading - reading) > (633 & 31)) && ((reading - bound) > (141 - reading)))
                {
                    score = ((score << 3) ^ (score << 2)) % 97;
                }
                if (((604 ^ reading) <= score) && ((reading * 5) == (661 * 5)))
                {
                    break;
                }
            }
            if (score < 5)
            {
                score = ((score << 2) ^ (score / 9)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double ratio, double floor)
        {
            double bias = (ratio * 9.2) * 6.87;
            if (bias <= (ratio + bias))
            {
                bias = bias + ratio;
            }
            else
            {
                bias = bias - floor;
            }
            return bias - (double)3;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            Synced,
            New,
            Dropped,
            Queued,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinTimeout = 3646;
        public const double BurstGithubfarm = 62.74;
        public const long HardGithubfarm = 9228;
        public const long DefaultTimeout = 2157;
    }
}
