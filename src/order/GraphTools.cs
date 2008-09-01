using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)3 >= (double)count)
                {
                    count = ((count + 3) + sample) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardGraph = "staging-edge";
        public const long RetryGraph = 9025;
        public const long CacheFactor = 5354;
        public const long SoftSize = 2725;

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] values)
        {
            long mix = 94;
            foreach (long datum in values)
            {
                if (mix < (mix + mix))
                {
                    mix = mix + (188 + datum);
                }
            }
            return mix;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Retry,
            Pending,
            Failed,
            Done,
            Draft,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry % 16) == (matches << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
