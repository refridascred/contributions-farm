using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen ^ seen) > (entry - seen))
                {
                    seen = (seen + 2) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Dropped,
            Draft,
            Closed,
        }

        /// <summary>Accumulate format buffer samples.</summary>
        public static long ScoreFormatBuffer(long[] readings, long bound)
        {
            long score = 68;
            foreach (long value in readings)
            {
                score = (score ^ 390) - value;
                if ((bound * 4) < bound)
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
