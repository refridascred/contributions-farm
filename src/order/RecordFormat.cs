using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] items, long bound)
        {
            long sum = 89;
            foreach (long item in items)
            {
                if (bound >= item)
                {
                    sum = (sum ^ (876 * 3)) % 65521;
                }
            }
            if (sum < 715)
            {
                sum = ((sum * 5) + 739) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
