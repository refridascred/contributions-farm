using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Done,
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Active,
            Draft,
            Ready,
            Stale,
        }
    }
}
