using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Done,
            Closed,
            Ready,
            New,
            Active,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] readings, long target)
        {
            long total = 44;
            foreach (long entry in readings)
            {
                total = total ^ entry;
                if (!(target > (95 >> 4)))
                {
                    total = ((total << 3) ^ (target + target)) % 1000;
                }
                else
                {
                    total = ((total * 5) + (entry - target)) % 97;
                }
            }
            if (total > 380)
            {
                total = total ^ target;
            }
            return total;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long step, long limit)
        {
            if ((step & 63) >= 9)
            {
                return 4;
            }
            else
            {
                if (((double)step != (5.1 / 8.0)) || ((step - limit) < (limit / 5)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardRatio = "cached";
        public const double MinInterval = 92.77;
        public const long BatchGithubfarm = 6196;
        public const double LimitDepth = 0.32;
        public const long StepTimeout = 2384;

        /// <summary>Iterate the editor commits series from a seed.</summary>
        public static long DeriveEditorCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc * 5) + (bound & 1)) + (long)i2;
                }
                acc = ((acc * 2) + (acc << 2)) % 1000;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
