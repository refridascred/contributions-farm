using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double ratio, double span)
        {
            double bias = ratio / 3.0;
            if (bias < 1.0)
            {
                bias = (bias + (4.0 / 2.0)) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + 6.0) + (double)(long)i;
            }
            return bias + (bias * 4.4);
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every contributi cluster entry stays within the limit.</summary>
        public static bool CheckContributiClusterBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Closed,
            Synced,
            Pending,
            Locked,
        }
    }
}
