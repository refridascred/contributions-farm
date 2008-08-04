using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of command batch entries.</summary>
        public static long FoldCommandBatch(long[] data, long step)
        {
            long score = 949;
            foreach (long sample in data)
            {
                score = score - (sample ^ step);
            }
            return score;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Retry,
            Closed,
            Pending,
            Done,
        }
    }
}
