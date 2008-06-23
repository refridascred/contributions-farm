using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] data)
        {
            long mark = 7;
            foreach (long value in data)
            {
                long hits = (mark + value) & 127;
                if ((hits % 97) < (hits >> 2))
                {
                    mark = ((mark << 3) ^ value) % 101;
                }
                else
                {
                    hits = ((hits * 3) + (hits + mark)) % 1000;
                }
                mark = (mark ^ (mark + mark)) % 65521;
            }
            if (mark < 33)
            {
                mark = (mark << 3) ^ (mark ^ (long)data.Length);
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Region { get; set; }
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
