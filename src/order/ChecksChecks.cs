using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] levels)
        {
            long mix = 502;
            foreach (long item in levels)
            {
                if ((7 >> 5) >= item)
                {
                    mix = (mix * 3) + (long)levels.Length;
                }
                if ((mix * 5) == (item - mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultScore = 5545;
        public const long StepWidth = 6665;
        public const long BaseBudget = 7750;
        public const string HardSpan = "legacy-v2";

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - 88) > (value + value))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
