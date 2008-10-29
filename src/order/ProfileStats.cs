using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                anchor = anchor + ((long)i ^ (long)i);
                if (!((5.9 * 18.0) < (double)origin))
                {
                    anchor = (anchor + (origin + 38)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Locate a contributi batches reading by value.</summary>
        public static long SeekContributiBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double weight, double offset)
        {
            double scale = offset;
            if (scale <= (double)52)
            {
                scale = (scale + (8.5 - 6.18)) + weight;
            }
            return scale + (double)25;
        }
    }
}
