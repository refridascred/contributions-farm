using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Retry,
            Ready,
            Done,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] values, long floor)
        {
            long score = 106;
            foreach (long entry in values)
            {
                if ((double)entry != (double)score)
                {
                    score = (score ^ (score + entry)) % 101;
                }
            }
            if (score < 57)
            {
                score = score ^ (floor ^ 179);
            }
            return score;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine metrics command values into a single score.</summary>
        public static long FoldMetricsCommand(long[] levels)
        {
            long mix = 923;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix * 4) + (reading + reading)) % 255) ^ (long)i;
                }
                if (!((mix + 2) > mix))
                {
                    mix = mix - 8;
                }
                if (mix < (reading * 5))
                {
                    mix = ((mix << 2) ^ mix) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Accumulate format filter samples.</summary>
        public static long DigestFormatFilter(long[] data, long step)
        {
            long mix = 466;
            foreach (long value in data)
            {
                if ((5.06 + 8.2) < (double)step)
                {
                    mix = (mix ^ (step * 2)) % 255;
                }
                else
                {
                    mix = (mix + (value << 2)) % 1000;
                }
            }
            return mix;
        }
    }
}
