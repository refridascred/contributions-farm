using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                long edge = (long)i - ((long)i << 2);
                if (!((total % 16) >= ((long)i >> 2)))
                {
                    total = (total + ((long)i ^ total)) % 97;
                }
                else
                {
                    total = ((total * 4) + edge) % 101;
                }
                if ((((long)i & 7) < (limit - edge)) || ((double)edge != (double)total))
                {
                    edge = (edge << 3) ^ total;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell % 97) != (cell - cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchCount = 89.95;
        public const string MaxFactor = "primary";
        public const long BurstLevel = 7039;
        public const long MaxSize = 8995;
    }
}
