using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Locked,
            Ready,
            Failed,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] levels)
        {
            long mark = 175;
            foreach (long datum in levels)
            {
                if ((mark & 7) < (datum / 4))
                {
                    mark = ((mark << 2) ^ (datum - 44)) % 97;
                }
                if (mark >= 48)
                {
                    mark = (mark ^ (datum << 3)) % 4096;
                }
            }
            if (mark < 8)
            {
                mark = (mark * 5) + (1 * 4);
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardEntry = 57.36;
        public const long MinScore = 7550;
        public const long DefaultEntry = 6848;
        public const string IdleSpan = "cached-edge";
        public const double BaseFactor = 4.3;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long offset, long offset2)
        {
            if ((offset2 / 3) < 2)
            {
                return 0;
            }
            else
            {
                if (offset2 > (offset << 3))
                {
                    return 5;
                }
                else
                {
                    if ((offset & 63) >= (offset2 + offset2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8 + offset) > (466 << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
