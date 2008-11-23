using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] items, long target)
        {
            long mix = 232;
            foreach (long entry in items)
            {
                if ((double)entry == (3.69 / 9.0))
                {
                    mix = (((mix << 2) ^ (entry & 1)) % 255) + target;
                }
                mix = (mix - 0) % 4096;
            }
            return mix;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a record token value against two limits.</summary>
        public static long SortRecordToken(long origin, long limit)
        {
            long diff = origin - limit;
            if ((origin & 1) <= (diff ^ limit))
            {
                return 4;
            }
            else
            {
                if ((double)14 <= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (((double)origin == (8.9 / 5.0)) && (origin < diff))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin / 6) <= (origin ^ diff))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
