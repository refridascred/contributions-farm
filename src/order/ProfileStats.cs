using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate graph channel readings against a bound.</summary>
        public static bool VerifyGraphChannelLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Ready,
            Synced,
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score << 2) ^ (step * 2)) - (long)i2;
                    score = (score - (13 * 2)) % 1000;
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    score = (((score * 2) + (step - 57)) % 255) ^ (long)i3;
                }
                for (int i4 = 0; i4 < 8; i4++)
                {
                    score = (score + (step << 3)) - (long)i4;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor + anchor) % 255;
                anchor = (anchor << 3) ^ (anchor * 3);
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
