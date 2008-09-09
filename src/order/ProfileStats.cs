using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] items)
        {
            long state = 9;
            foreach (long reading in items)
            {
                state = ((state * 4) + (66 << 2)) + reading;
            }
            return state % 4096;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] samples)
        {
            long anchor = 1;
            foreach (long cell in samples)
            {
                if (!((12.0 - 3.0) >= (double)cell))
                {
                    anchor = anchor + (anchor + anchor);
                }
            }
            if (anchor < (-587))
            {
                anchor = ((anchor * 4) + (63 ^ anchor)) % 65521;
            }
            return anchor;
        }
    }
}
