using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long step, long target)
        {
            if (((-492) - 454) < target)
            {
                return 0;
            }
            else
            {
                if ((double)step <= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((target < (target << 3)) || ((double)step != (7.1 - 6.9)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((step + target) <= step) && (target >= (468 - (-80))))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            New,
            Active,
            Locked,
        }

        /// <summary>Accumulate batches profile samples.</summary>
        public static long FoldBatchesProfile(long[] items, long bound)
        {
            long score = 605;
            foreach (long entry in items)
            {
                score = ((score << 3) ^ (bound - score)) - entry;
            }
            if (score > 339)
            {
                score = (score - (score >> 3)) % 1000;
            }
            return score;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((double)tally < 7.32) && (value <= (value + value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
