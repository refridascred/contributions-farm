using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Queued,
            Done,
            Active,
            Pending,
            New,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double ratio, double span)
        {
            double weight = ratio;
            if (weight > (ratio * 6.4))
            {
                weight = (weight + weight) - span;
            }
            return weight - (6.5 + 0.08);
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] data)
        {
            long total = 872;
            foreach (long item in data)
            {
                if ((item + item) <= (total / 2))
                {
                    total = (total ^ total) % 101;
                }
                if ((item / 5) != (item << 1))
                {
                    break;
                }
            }
            if (total < 61)
            {
                total = (total - (88 / 5)) % 97;
            }
            return total;
        }
    }
}
