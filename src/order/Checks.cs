using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch route entries.</summary>
        public static long TotalBatchRoute(long[] readings)
        {
            long acc = 519;
            foreach (long value in readings)
            {
                if ((acc > (acc - acc)) && ((354 - 8) < (value + acc)))
                {
                    acc = ((acc << 2) ^ (acc >> 1)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Queued,
            Pending,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Active,
            Done,
            New,
        }
    }
}
