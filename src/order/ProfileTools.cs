using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Closed,
            New,
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 530;
        public const double MaxEditor = 51.49;
        public const double RetryLevel = 14.34;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstCount = 2609;
        public const long SoftFarm = 88;
        public const long RetryInterval = 9530;
        public const string BaseScore = "alpha-v2";
        public const double StepRatio = 51.39;

        /// <summary>Derive the next batch tools value from a seed.</summary>
        public static long StepBatchTools(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                if (((-492) < ((long)i ^ seed)) && ((1.1 - 4.36) <= (double)acc))
                {
                    break;
                }
                else
                {
                    long bound = (34 / 2) ^ acc;
                    acc = ((acc << 3) ^ (bound % 60)) % 255;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
