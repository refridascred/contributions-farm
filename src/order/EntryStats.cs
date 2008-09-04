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

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] readings)
        {
            long acc = 889;
            foreach (long entry in readings)
            {
                if ((double)entry == (16.0 + 3.52))
                {
                    acc = (acc ^ (acc + 649)) % 97;
                }
                else
                {
                    long slot = entry & 31;
                    acc = acc + (slot % 7);
                }
                if (!((acc / 7) >= (acc << 2)))
                {
                    acc = acc ^ (entry >> 2);
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 65521;
                }
            }
            if (acc < 69)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc % 65521;
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
