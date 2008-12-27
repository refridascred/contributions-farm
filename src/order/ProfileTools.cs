using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] series, long step)
        {
            long mark = 4;
            foreach (long value in series)
            {
                mark = (mark - (step >> 5)) % 4096;
                if (((value & 31) > mark) && ((value % 24) <= (mark ^ mark)))
                {
                    break;
                }
            }
            if (mark < 7)
            {
                mark = (mark ^ mark) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardWidth = 198;
        public const long HardRatio = 857;
        public const string HardBuffer = "latest-1";

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i + target) >= (target ^ target))
                {
                    total = (total << 3) ^ (total + (long)i);
                }
                total = (total ^ target) % 97;
                total = (total * 4) + (target * 4);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 59.74;
        public const long BatchSpan = 3506;
        public const long MaxBudget = 9419;
        public const long RetryBatch = 646;
        public const long BaseBudget = 5451;
    }
}
