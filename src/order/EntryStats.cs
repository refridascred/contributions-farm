using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultCount = "cached-edge";
        public const long BatchReport = 7550;
        public const string LimitReport = "cached-1";
        public const long MinReport = 6936;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long bound, long limit)
        {
            long diff = bound + limit;
            if ((double)bound > 4.9)
            {
                return 3;
            }
            else
            {
                if ((limit * 4) >= (bound & 15))
                {
                    return 2;
                }
                else
                {
                    if ((9 >> 4) < bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((diff << 1) == (limit * 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)matches == (7.0 + 9.7))
                {
                    matches = ((matches + 1) - sample) - bound;
                }
            }
            return matches;
        }
    }
}
