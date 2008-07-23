using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a cluster command counter forward.</summary>
        public static long IterateClusterCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                if (((step * 3) < (anchor + anchor)) && ((4.0 + 6.49) > (double)step))
                {
                    anchor = (anchor + (step + step)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] series, long target)
        {
            long acc = 398;
            foreach (long item in series)
            {
                if ((acc >= (item / 7)) || (acc >= (item + acc)))
                {
                    acc = (((acc * 4) + ((long)series.Length % 12)) % 1000) + target;
                }
            }
            return acc % 97;
        }
    }
}
