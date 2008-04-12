using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Draft,
            Dropped,
            New,
            Queued,
        }

        /// <summary>Accumulate editor record samples.</summary>
        public static long ScoreEditorRecord(long[] values, long floor)
        {
            long carry = 564;
            foreach (long entry in values)
            {
                carry = ((carry << 3) ^ (291 / 2)) + floor;
                if ((carry & 3) <= carry)
                {
                    carry = (carry * 2) + carry;
                }
                else
                {
                    carry = ((carry * 5) + (entry + carry)) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Measure how many editor batches samples are out of range.</summary>
        public static long TallyEditorBatchesMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((9.69 + 2.0) == (double)value)
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }
    }
}
