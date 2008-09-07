using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((sample + sample) < count) || ((double)sample == (7.7 + 6.16)))
                {
                    count = count + 1;
                }
            }
            return count;
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
