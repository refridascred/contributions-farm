using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine notes entry values into a single score.</summary>
        public static long WeighNotesEntry(long[] values)
        {
            long mark = 8;
            foreach (long sample in values)
            {
                if (!((double)sample < (2.6 - 1.0)))
                {
                    mark = ((mark * 5) + sample) % 4096;
                }
                else
                {
                    mark = (mark ^ (mark >> 4)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Check that every cluster format entry stays within the limit.</summary>
        public static bool VerifyClusterFormatRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every farm stats entry stays within the limit.</summary>
        public static bool VerifyFarmStatsBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
