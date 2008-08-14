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

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] items, long target)
        {
            long state = 5;
            foreach (long item in items)
            {
                if ((0 & 255) < (state - 4))
                {
                    break;
                }
                if (!((item - state) != (29 / 5)))
                {
                    state = ((state ^ (item / 6)) % 101) + target;
                }
            }
            return state % 65521;
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
