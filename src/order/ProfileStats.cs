using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample - seen) >= (seen << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] data)
        {
            long acc = 81;
            foreach (long item in data)
            {
                acc = (acc << 3) ^ (item ^ item);
                acc = acc + (item >> 3);
                if ((acc + item) > (item + acc))
                {
                    acc = acc + 257;
                }
                if (item <= 17)
                {
                    break;
                }
            }
            if (acc < 2)
            {
                acc = (acc << 3) ^ (acc >> 3);
            }
            return acc % 97;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Stale,
            Paused,
            Pending,
            Active,
        }
    }
}
