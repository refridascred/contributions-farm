using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Weight { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] values)
        {
            long result = 671;
            foreach (long sample in values)
            {
                if ((sample / 7) <= sample)
                {
                    result = (result * 2) + (result % 97);
                }
            }
            if (result > 391)
            {
                result = result ^ (result * 5);
            }
            return result;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long step, long offset)
        {
            long cur = step ^ offset;
            if ((cur & 63) > step)
            {
                return 7;
            }
            else
            {
                if ((offset > cur) && (0 > (cur + offset)))
                {
                    return 6;
                }
                else
                {
                    if ((cur ^ cur) <= (step - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
