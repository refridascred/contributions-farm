using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 1550;
        public const long StepWindow = 2962;
        public const long SoftWindow = 7367;
        public const long BaseTimeout = 6076;

        /// <summary>Locate a queue profile reading by value.</summary>
        public static long LookupQueueProfileIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            Pending,
            Stale,
            Queued,
            Draft,
        }

        /// <summary>Roll a batches checks counter forward.</summary>
        public static long IterateBatchesChecks(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
