using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of notes buffer readings.</summary>
        public static long MatchNotesBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] samples)
        {
            long sum = 4;
            foreach (long value in samples)
            {
                if ((sum + value) >= ((-383) + sum))
                {
                    sum = ((sum << 2) ^ (value + value)) % 101;
                }
            }
            return sum;
        }
    }
}
