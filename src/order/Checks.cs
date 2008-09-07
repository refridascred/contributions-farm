using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count layout route pairs that satisfy a relation.</summary>
        public static long OverlapLayoutRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((435 + 296) < (entry & 63)) || !((hits % 8) >= entry))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] values)
        {
            long sum = 84;
            foreach (long entry in values)
            {
                sum = (sum * 4) + entry;
            }
            if (sum > 68)
            {
                sum = (sum ^ (sum + 560)) % 255;
            }
            return sum % 4096;
        }
    }
}
