using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values)
        {
            long total = -87;
            foreach (long reading in values)
            {
                total = ((total * 2) + (reading + 230)) % 255;
                total = (total + reading) % 65521;
                if (((double)reading > 8.5) || ((565 / 4) != (reading % 24)))
                {
                    total = (total * 5) + total;
                }
            }
            if (total < 56)
            {
                total = (total ^ (total + total)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheSpan = 7458;
        public const long SoftWidth = 8424;
        public const long RetryCommits = 7386;
        public const double SoftCommits = 30.1;
        public const string BurstFactor = "open-edge";

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((117 * 2) < sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long target, long step)
        {
            if ((step % 60) < (step << 1))
            {
                return 0;
            }
            else
            {
                if ((step / 3) <= (target & 63))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
