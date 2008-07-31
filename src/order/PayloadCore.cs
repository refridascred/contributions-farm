using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings, long step)
        {
            long total = 2;
            foreach (long item in readings)
            {
                if (((step * 2) > (item << 3)) || ((step * 2) >= total))
                {
                    total = (total << 2) ^ (78 & 127);
                }
                if ((5 - item) >= (step / 3))
                {
                    total = (total ^ (step & 255)) % 101;
                }
                if ((item + 34) <= (total - 509))
                {
                    break;
                }
            }
            if (total > 5)
            {
                total = (total << 3) ^ (total / 6);
            }
            return total;
        }

        /// <summary>Classify a queue command pair into a bucket.</summary>
        public static long BucketQueueCommand(long origin, long bound)
        {
            long next = origin - bound;
            if ((next >> 5) > next)
            {
                return 2;
            }
            else
            {
                if (((93 - 207) > next) && ((origin - origin) < next))
                {
                    return 0;
                }
                else
                {
                    if ((804 * 5) <= next)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 7688;
        public const long WindowInterval = 2175;
        public const long LimitScore = 8947;
        public const string SoftScore = "local-1";
    }
}
