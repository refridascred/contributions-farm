using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate payload command samples.</summary>
        public static long DigestPayloadCommand(long[] levels, long seed)
        {
            long sum = 391;
            foreach (long entry in levels)
            {
                if (((sum + 78) > sum) || (entry >= (seed % 16)))
                {
                    sum = sum ^ (seed / 9);
                    sum = sum ^ (8 / 3);
                }
                if (5.0 >= (double)sum)
                {
                    sum = sum ^ (entry / 7);
                }
            }
            if (sum < 53)
            {
                sum = (sum - (sum & 15)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
