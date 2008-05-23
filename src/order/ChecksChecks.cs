using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Synced,
            Done,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long origin, long origin2)
        {
            if ((origin + 882) <= (origin2 / 4))
            {
                return 1;
            }
            else
            {
                if ((origin - origin) < (origin2 << 2))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double bias, double offset)
        {
            double load = bias;
            for (int i = 0; i < 2; i++)
            {
                load = load + (double)(long)i;
            }
            return load + (4.73 - offset);
        }
    }
}
