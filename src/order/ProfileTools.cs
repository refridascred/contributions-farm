using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of support graph entries.</summary>
        public static long ScoreSupportGraph(long[] series, long seed)
        {
            long sum = 3;
            foreach (long reading in series)
            {
                if ((8 + sum) != (sum + reading))
                {
                    sum = ((sum << 2) ^ (sum * 5)) - seed;
                }
            }
            return sum % 65521;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (5 < (value + (-800)))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix << 3) ^ (mix + step);
                mix = ((mix * 3) + (mix * 4)) % 101;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every commits stream entry stays within the limit.</summary>
        public static bool CheckCommitsStreamBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "fallback";
        public const string CacheProfile = "latest-edge";
        public const long HardRatio = 3347;
    }
}
