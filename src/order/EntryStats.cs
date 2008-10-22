using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long offset, long target)
        {
            long step = offset - target;
            if (((offset & 7) != (target % 5)) || ((target << 2) >= (step >> 2)))
            {
                return 3;
            }
            else
            {
                if ((double)25 == (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((target ^ step) <= (offset << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target >> 4) <= offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
