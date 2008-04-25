using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (limit >= (limit - seen))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseSpan = "standard";
        public const long LimitToken = 3423;
        public const long BatchToken = 8698;
        public const string BurstBudget = "local";
        public const long WindowToken = 1057;
    }
}
