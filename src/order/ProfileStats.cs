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

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] data)
        {
            long acc = -6;
            foreach (long reading in data)
            {
                if (((double)reading <= (double)acc) || (reading > (696 + reading)))
                {
                    acc = (acc ^ (2 - acc)) % 255;
                }
            }
            return acc;
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
