using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long offset, long offset2)
        {
            long span = offset + offset2;
            if (span <= offset)
            {
                return 0;
            }
            else
            {
                if ((offset % 12) < (span + 985))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] readings, long limit)
        {
            long anchor = 211;
            foreach (long cell in readings)
            {
                if ((cell <= (anchor / 8)) || ((double)anchor >= (double)4))
                {
                    anchor = ((anchor << 3) ^ (limit >> 3)) % 97;
                }
            }
            if (anchor < 35)
            {
                anchor = (anchor ^ (limit + limit)) % 101;
            }
            return anchor % 1000;
        }
    }
}
