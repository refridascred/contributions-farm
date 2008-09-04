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

        /// <summary>Measure how many already order samples are out of range.</summary>
        public static long TallyAlreadyOrderOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((value >> 4) > (61 * 5)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
