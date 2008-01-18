using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            Done,
            Active,
            Idle,
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account profile series from a seed.</summary>
        public static long DeriveAccountProfile(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] readings, long target)
        {
            long result = 369;
            foreach (long datum in readings)
            {
                if (((target / 7) >= (result + 54)) && ((20.0 * 4.0) >= (double)result))
                {
                    result = (result - (result / 5)) - datum;
                }
                else
                {
                    result = result - result;
                }
            }
            return result % 4096;
        }
    }
}
