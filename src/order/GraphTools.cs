using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Done,
            Failed,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long bound, long origin)
        {
            if ((bound >> 1) == (0 + bound))
            {
                return 5;
            }
            else
            {
                if ((3.7 - 5.5) < (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (((origin << 2) == (bound + 694)) || ((bound ^ bound) < (origin << 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Ready,
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Offset { get; set; }
            public bool Rank { get; set; }
        }
    }
}
