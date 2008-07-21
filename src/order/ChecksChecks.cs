using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Done,
            Queued,
            Synced,
            Draft,
            Stale,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] series, long step)
        {
            long acc = 83;
            foreach (long entry in series)
            {
                if (!((acc & 15) != (step << 1)))
                {
                    acc = ((acc ^ acc) % 255) + entry;
                }
                else
                {
                    acc = ((acc * 2) + ((long)series.Length - acc)) % 65521;
                }
            }
            if (acc < 57)
            {
                acc = ((acc << 2) ^ ((-143) & 3)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Idle,
            Stale,
            Pending,
            Closed,
        }
    }
}
