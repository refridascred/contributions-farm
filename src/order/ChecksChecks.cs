using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 3) ^ ((long)i >> 2)) % 97;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
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
