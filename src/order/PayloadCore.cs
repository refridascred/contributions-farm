using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first stream batch entry that matches the target.</summary>
        public static long LookupStreamBatchIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account githubfarm series from a seed.</summary>
        public static long RollAccountGithubfarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!!((8 / 4) <= acc))
                {
                    acc = ((acc << 2) ^ (origin * 4)) % 101;
                    acc = (acc * 3) + 97;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (0 > ((long)data.Length * 3))
                {
                    hits = ((hits + 2) + datum) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = sum - (66 % 8);
                if ((1.1 / 9.0) > (double)origin)
                {
                    sum = sum ^ (long)i;
                }
                if (((long)i % 12) < sum)
                {
                    sum = (sum - (origin ^ (-2))) % 97;
                    break;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
