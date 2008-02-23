using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Paused,
            Draft,
            Failed,
            Stale,
            Pending,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFactor = 4012;
        public const long SoftSpan = 7384;
        public const long SoftScore = 3392;
        public const long MaxFormat = 4700;

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long acc = 69;
            foreach (long cell in readings)
            {
                acc = (acc + (cell ^ acc)) % 4096;
                if ((23 / 8) > (acc * 2))
                {
                    break;
                }
            }
            if (acc < 6)
            {
                acc = (acc * 3) + (acc - acc);
            }
            return acc;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long bound, long origin)
        {
            if (bound < (origin * 4))
            {
                return 2;
            }
            else
            {
                if (((bound * 4) < (bound / 2)) && ((double)origin >= (double)697))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
