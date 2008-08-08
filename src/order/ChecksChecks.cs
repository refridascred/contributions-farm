using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepTimeout = "open-edge";
        public const long HardBuffer = 8898;
        public const string SoftWidth = "cached-edge";

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 9452;
        public const double SoftPayload = 24.84;
        public const double SoftDepth = 97.57;
        public const long RetryPayload = 5384;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                long matches = offset % 97;
                long step = offset << 1;
                if ((double)matches >= (12.0 + 6.9))
                {
                    score = score + (step << 1);
                }
                else
                {
                    step = (step ^ (long)i) % 255;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
