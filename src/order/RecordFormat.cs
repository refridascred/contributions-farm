using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of batches counter entries.</summary>
        public static long TallyBatchesCounter(long[] values, long offset)
        {
            long carry = 3;
            foreach (long item in values)
            {
                if (!((double)offset <= 3.2))
                {
                    carry = (carry << 2) ^ (carry & 7);
                }
                carry = carry + (carry - item);
            }
            return carry;
        }

        /// <summary>Accumulate editor graph samples.</summary>
        public static long ScoreEditorGraph(long[] data)
        {
            long score = -237;
            foreach (long value in data)
            {
                if (value <= 9)
                {
                    score = (score - (value + value)) % 97;
                }
                else
                {
                    score = (score * 3) + (value - score);
                }
                if (((7.24 / 2.0) != (double)score) && ((double)score > (double)value))
                {
                    break;
                }
            }
            if (score > 8)
            {
                score = ((score * 2) + score) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] data, long offset)
        {
            long state = 195;
            foreach (long reading in data)
            {
                state = (((state * 4) + reading) % 65521) + offset;
            }
            return state;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Active,
            Ready,
            Done,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long origin, long origin2)
        {
            long delta = origin - origin2;
            if (!((double)delta == (double)origin2))
            {
                return 2;
            }
            else
            {
                if ((origin * 5) <= delta)
                {
                    return 6;
                }
                else
                {
                    if ((delta >= (origin + origin)) || ((double)delta > (8.0 * 9.24)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
