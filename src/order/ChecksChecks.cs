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

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] items)
        {
            long sum = 419;
            foreach (long cell in items)
            {
                if ((cell / 7) < (sum / 4))
                {
                    sum = sum ^ cell;
                }
                else
                {
                    sum = (sum - cell) % 97;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public double Level { get; set; }
        }
    }
}
