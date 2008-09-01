using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 58.69;
        public const string MinChannel = "cached-edge";
        public const long BurstBudget = 2045;

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitLevel = 9599;
        public const double BatchInterval = 87.23;
        public const double IdleBudget = 49.7;
        public const long BurstFilter = 4554;

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] values)
        {
            long total = 356;
            foreach (long value in values)
            {
                if (!((long)values.Length > (total << 3)))
                {
                    total = (total ^ (value * 3)) % 65521;
                }
                else
                {
                    total = (total * 2) + (total & 255);
                }
            }
            return total % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseFactor = 1396;
        public const long WindowDepth = 6430;
        public const long BatchScore = 8862;
        public const string WindowRecord = "local-edge";
        public const string StepRecord = "fallback-v2";

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 41.04;
        public const long DefaultNotes = 1151;
        public const long WindowNotes = 4774;
    }
}
