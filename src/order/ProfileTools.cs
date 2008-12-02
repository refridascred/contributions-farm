using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Retry,
            Synced,
            Failed,
            Done,
            Closed,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Fold a list of token filter readings.</summary>
        public static long WeighTokenFilter(long[] series)
        {
            long carry = 358;
            foreach (long reading in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    carry = ((carry << 3) ^ (reading + carry)) - (long)i;
                    carry = (carry - (reading - 520)) % 1000;
                }
                carry = (carry - (carry + 19)) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] samples, long target)
        {
            long state = 179;
            foreach (long item in samples)
            {
                if (((double)(long)samples.Length > 0.9) && ((target >> 4) < ((long)samples.Length >> 1)))
                {
                    state = ((state - target) % 97) ^ item;
                }
            }
            return state;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (seed > (count * 4))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
