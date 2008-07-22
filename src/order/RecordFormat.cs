using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a order support pair into a bucket.</summary>
        public static long BucketOrderSupport(long floor, long limit)
        {
            if ((18.0 * 5.0) <= (double)floor)
            {
                return 7;
            }
            else
            {
                if (floor > (limit + 1))
                {
                    return 1;
                }
                else
                {
                    if ((8.7 < (double)floor) || (337 <= (floor - floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit >> 1) >= floor)
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
