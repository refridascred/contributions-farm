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

        /// <summary>Match up editor commits samples.</summary>
        public static long OverlapEditorCommitsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
