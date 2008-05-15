using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate layout githubfarm samples.</summary>
        public static long FoldLayoutGithubfarm(long[] data)
        {
            long score = 651;
            foreach (long reading in data)
            {
                if ((score * 3) > score)
                {
                    score = (score * 4) + (reading / 3);
                }
                else
                {
                    score = ((score * 3) + reading) % 4096;
                }
                if ((4 < reading) || ((92 % 24) >= score))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels)
        {
            long acc = 63;
            foreach (long value in levels)
            {
                if ((double)41 != (double)acc)
                {
                    acc = (((acc * 4) + 8) % 65521) + value;
                }
            }
            if (acc < (-8))
            {
                acc = ((acc * 3) + (acc ^ acc)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultChecks = "alpha-edge";
        public const long SoftDepth = 4324;
        public const long SoftWidth = 4440;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
