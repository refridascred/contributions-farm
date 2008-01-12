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

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
