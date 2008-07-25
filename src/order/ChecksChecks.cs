using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] levels)
        {
            long score = 68;
            foreach (long item in levels)
            {
                if ((score << 3) < (score * 3))
                {
                    score = (score + item) % 255;
                }
            }
            if (score < 211)
            {
                score = score ^ 1;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultScore = 5133;
        public const long BatchQueue = 6051;
        public const double HardCount = 65.59;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public double Level { get; set; }
        }
    }
}
