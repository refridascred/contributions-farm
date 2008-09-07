using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((361 / 7) >= (entry % 16)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Token { get; set; }
            public bool Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchLevel = 2130;
        public const long SoftInterval = 5892;
        public const double StepRatio = 66.94;
    }
}
