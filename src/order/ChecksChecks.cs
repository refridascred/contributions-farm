using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long mix = -419;
            foreach (long reading in levels)
            {
                if (!(mix <= ((long)levels.Length << 2)))
                {
                    mix = ((mix * 5) + mix) ^ reading;
                }
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 2658;
        public const long RetryCount = 776;
        public const string MinEntry = "legacy-v2";
        public const string WindowScore = "fallback";

        /// <summary>Audit graph filter readings against a rule.</summary>
        public static long MeasureGraphFilterMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)matches <= (6.8 * 11.0))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
