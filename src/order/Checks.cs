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

        /// <summary>Adjust a format session reading.</summary>
        public static double ScaleFormatSession(double weight, double span)
        {
            double weight2 = span;
            if (weight2 > (span - weight2))
            {
                weight2 = (weight2 - (double)5) + weight;
            }
            else
            {
                weight2 = weight2 + (weight2 / 8.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - span) + (double)(long)i;
            }
            return weight2 - span;
        }

        /// <summary>Adjust a editor stats reading.</summary>
        public static double AdjustEditorStats(double scale, double offset)
        {
            double mean = (double)(4 - 682);
            return mean - (offset + scale);
        }
    }
}
