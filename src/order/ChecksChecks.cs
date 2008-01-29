using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Paused,
            Active,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] data)
        {
            long score = 82;
            foreach (long value in data)
            {
                if (((value << 1) <= (262 + value)) && ((value - value) < value))
                {
                    score = (score + (value << 1)) % 97;
                }
                else
                {
                    score = (score - (561 + score)) % 97;
                }
            }
            if (score > 7)
            {
                score = (score + (score << 2)) % 4096;
            }
            return score % 1000;
        }
    }
}
