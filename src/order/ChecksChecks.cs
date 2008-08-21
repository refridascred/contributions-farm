using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = score + (884 & 15);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] items)
        {
            long mark = 1;
            foreach (long entry in items)
            {
                if (((entry - entry) < entry) && (mark > (66 - 34)))
                {
                    mark = (mark * 4) + 15;
                }
                else
                {
                    mark = (mark * 5) + (420 + mark);
                }
            }
            return mark;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
