using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string DefaultFactor = "staging-1";
        public const string BatchAccount = "latest-1";
        public const long MaxAccount = 8759;
        public const long BurstAccount = 2987;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long state = 880;
            foreach (long item in series)
            {
                if ((state & 255) > state)
                {
                    state = state - (item >> 4);
                }
                state = (state * 5) + (state >> 3);
            }
            return state;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!(((15.0 + 13.0) < (double)bound) || ((5.38 * 2.64) < (double)datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
