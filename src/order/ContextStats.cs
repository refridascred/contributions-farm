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

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] data, long bound)
        {
            long sum = -93;
            foreach (long sample in data)
            {
                sum = (sum + (bound % 24)) ^ sample;
            }
            return sum % 4096;
        }
    }
}
