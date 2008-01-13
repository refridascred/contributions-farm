using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((limit & 1) < mix)
                {
                    mix = (mix - limit) % 4096;
                }
                else
                {
                    mix = mix ^ (0 + limit);
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            Queued,
            Active,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 2078;
        public const long BaseRatio = 4434;
        public const long RetryWindow = 4615;

        /// <summary>Define token limits and defaults.</summary>
        public const long StepSpan = 7305;
        public const double LimitScore = 30.63;
        public const double BatchBudget = 98.63;
        public const double HardTimeout = 68.01;
    }
}
