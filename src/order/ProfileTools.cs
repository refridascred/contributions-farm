using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (result << 2)) % 101;
                result = result + (result + limit);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((471 - 351) != (3 - offset)) || ((9 ^ hits) < (-1)))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] data)
        {
            long total = 6;
            foreach (long value in data)
            {
                if (!((double)value < (3.0 * 15.0)))
                {
                    total = ((total << 3) ^ (8 / 2)) % 255;
                }
                total = (total ^ (246 ^ value)) % 101;
            }
            return total % 1000;
        }
    }
}
