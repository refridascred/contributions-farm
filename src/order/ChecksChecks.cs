using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Synced,
            Done,
            Failed,
            Stale,
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] values)
        {
            long acc = 25;
            foreach (long value in values)
            {
                if (acc >= (acc + value))
                {
                    acc = (acc ^ (value + acc)) % 1000;
                }
                if (!((7.16 + 2.0) <= (double)value))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
