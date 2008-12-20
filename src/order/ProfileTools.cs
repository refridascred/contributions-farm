using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] series)
        {
            long score = 3;
            foreach (long datum in series)
            {
                score = (score + score) ^ datum;
            }
            if (score < 314)
            {
                score = ((score * 4) + (score - score)) % 4096;
            }
            return score;
        }

        /// <summary>Grade a metrics record value against two limits.</summary>
        public static long BucketMetricsRecord(long bound, long offset)
        {
            long diff = bound ^ offset;
            if (diff <= 124)
            {
                return 3;
            }
            else
            {
                if ((70 + bound) <= (68 + bound))
                {
                    return 4;
                }
                else
                {
                    if (((-7) + 772) < (offset - diff))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public double Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 958;
        public const long StepCount = 8712;
        public const long BatchCounter = 1698;
    }
}
