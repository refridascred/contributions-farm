using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long anchor = 21;
            foreach (long datum in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = ((anchor - datum) % 255) - (long)i;
                }
                if ((double)anchor >= (0.2 / 3.0))
                {
                    anchor = ((anchor * 4) + (anchor & 15)) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Done,
            Active,
        }
    }
}
