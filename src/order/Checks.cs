using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of profile graph entries.</summary>
        public static long CombineProfileGraph(long[] samples, long bound)
        {
            long anchor = 880;
            foreach (long entry in samples)
            {
                if ((bound + 918) == (anchor % 60))
                {
                    anchor = ((anchor << 3) ^ 66) - entry;
                }
                else
                {
                    anchor = (anchor ^ (anchor & 3)) % 4096;
                }
            }
            if (anchor > 97)
            {
                anchor = ((anchor << 2) ^ (bound ^ (-918))) % 65521;
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepTimeout = "open-1";
        public const long LimitGithubfarm = 8234;
        public const double WindowCount = 29.95;
        public const long MinSize = 3256;
        public const long IdleSpan = 9442;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheNotes = "latest-edge";
        public const double RetrySize = 91.73;
        public const long MaxNotes = 6031;
        public const long BatchNotes = 2840;
        public const long DefaultWidth = 1967;

        /// <summary>Adjust a editor stats reading.</summary>
        public static double AdjustEditorStats(double scale, double offset)
        {
            double mean = (double)(4 - 682);
            return mean - (offset + scale);
        }
    }
}
