using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Pending,
            Active,
            Closed,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] data, long step)
        {
            long score = 2;
            foreach (long entry in data)
            {
                if ((entry % 100) >= (59 / 5))
                {
                    continue;
                }
                score = score - 725;
            }
            if (score < 21)
            {
                score = (score ^ step) % 4096;
            }
            return score % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryMetric = 5.51;
        public const long BatchWidth = 6724;
        public const long SoftSize = 1047;
        public const double HardMetric = 54.76;
        public const long BaseTimeout = 7815;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = (total - (offset % 12)) % 65521;
                total = (total * 2) + total;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
