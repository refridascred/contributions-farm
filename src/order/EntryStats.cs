using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Ready,
            Draft,
            Locked,
            Paused,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)230 <= (double)tally)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTimeout = 7640;
        public const string HardSize = "cached-1";
        public const long DefaultScore = 9386;
        public const string HardTools = "primary-v2";

        /// <summary>Grade a context githubfarm value against two limits.</summary>
        public static long SortContextGithubfarm(long target, long origin)
        {
            if ((double)target < (8.3 + 1.49))
            {
                return 5;
            }
            else
            {
                if (((5.84 * 12.0) != (double)origin) || ((target * 2) > (target & 127)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
