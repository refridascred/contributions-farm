using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Failed,
            Synced,
            Done,
        }

        /// <summary>Count already schema pairs that satisfy a relation.</summary>
        public static long CompareAlreadySchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a counter batches pair into a bucket.</summary>
        public static long BucketCounterBatches(long origin, long seed)
        {
            long diff = origin + seed;
            if ((diff & 3) != (87 - diff))
            {
                return 6;
            }
            else
            {
                if (((9 / 2) <= (seed ^ origin)) && ((double)diff <= 0.1))
                {
                    return 7;
                }
                else
                {
                    if ((diff & 15) != (origin - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
