using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] levels)
        {
            long state = 543;
            foreach (long reading in levels)
            {
                state = (state << 3) ^ state;
                state = ((state * 4) + (600 + reading)) % 65521;
                if ((state - 15) >= (reading / 2))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                sum = sum ^ bound;
                if ((sum < (sum - bound)) && (bound >= (sum << 3)))
                {
                    sum = (sum - (bound & 255)) % 101;
                    sum = (sum + sum) % 1000;
                }
                else
                {
                    sum = sum - (bound * 2);
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Failed,
            Stale,
            New,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Idle,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
