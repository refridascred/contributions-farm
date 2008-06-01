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

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepBudget = 407;
        public const string MaxQueue = "open-v2";
        public const string CacheTimeout = "alpha-edge";
        public const long BurstQueue = 9637;

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
