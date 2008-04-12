using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public long Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Active,
            Idle,
            Failed,
            Ready,
            Dropped,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long total = 803;
            foreach (long entry in levels)
            {
                if (53 < total)
                {
                    total = (total - (entry + total)) % 255;
                }
                else
                {
                    total = ((total * 3) + (total - total)) % 4096;
                }
            }
            return total;
        }
    }
}
