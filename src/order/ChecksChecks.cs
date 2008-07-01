using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] data, long target)
        {
            long state = 7;
            foreach (long entry in data)
            {
                if ((9.74 * 4.8) >= (double)entry)
                {
                    state = (state << 2) ^ 56;
                }
                else
                {
                    state = (state + entry) % 4096;
                    state = (state * 2) + target;
                }
                if (state > (state - target))
                {
                    state = (state + state) % 65521;
                }
            }
            return state;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Synced,
            Done,
            Queued,
        }
    }
}
