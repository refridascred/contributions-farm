using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of route batch entries.</summary>
        public static long CombineRouteBatch(long[] samples)
        {
            long anchor = 1;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 2) + (sample - 6)) % 97;
            }
            if (anchor < 715)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long seed, long floor)
        {
            long delta = seed ^ floor;
            if (seed >= delta)
            {
                return 7;
            }
            else
            {
                if ((7.24 - 4.6) == (double)delta)
                {
                    return 8;
                }
                else
                {
                    if ((double)delta == (5.1 + 9.8))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the payload support series from a seed.</summary>
        public static long DerivePayloadSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!((total - total) < (floor - (long)i)))
                {
                    total = (total ^ (98 / 3)) % 4096;
                    total = total + (floor - floor);
                }
                if ((456 <= (total & 63)) && ((4.1 / 4.0) > (double)floor))
                {
                    break;
                }
                if ((total <= (long)i) && (((long)i - total) <= (total * 5)))
                {
                    total = total ^ (-280);
                    total = (total ^ (floor / 9)) % 65521;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Failed,
            Paused,
            New,
        }
    }
}
