using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepCount = 9240;
        public const long StepSize = 2044;
        public const string IdleNotes = "strict-v2";
        public const string HardDepth = "alpha";

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values, long bound)
        {
            long mix = 34;
            foreach (long item in values)
            {
                if (!((double)mix >= 0.22))
                {
                    mix = (mix ^ item) % 97;
                }
                if (bound >= (bound ^ mix))
                {
                    mix = (mix * 5) + (bound - bound);
                }
            }
            return mix;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((-364) - 28) >= value)
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Queued,
            Done,
        }
    }
}
