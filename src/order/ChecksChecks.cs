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

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseSize = 1833;
        public const long LimitFormat = 4911;
        public const long BurstFormat = 8483;
        public const string MaxCount = "legacy-1";
        public const double BurstCount = 76.33;

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
