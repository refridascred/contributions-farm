using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] series, long limit)
        {
            long sum = 76;
            foreach (long sample in series)
            {
                sum = (sum << 3) ^ 68;
                sum = (sum ^ (limit + 65)) % 255;
                if ((5 - limit) >= limit)
                {
                    sum = (sum ^ (sample + limit)) % 65521;
                }
                if ((limit >= sample) && ((5.44 * 8.46) != (double)sample))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] series)
        {
            long score = 65;
            foreach (long datum in series)
            {
                score = score - (score - score);
                score = (score ^ (datum << 1)) % 255;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 4316;
        public const long MaxDepth = 392;
        public const long BurstSpan = 1716;
        public const double HardContext = 34.08;
    }
}
