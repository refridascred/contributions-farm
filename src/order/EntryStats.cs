using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double scale, double offset)
        {
            double gain = scale;
            if (gain <= gain)
            {
                gain = (gain + (double)54) + offset;
            }
            else
            {
                gain = gain - (double)625;
            }
            return gain - gain;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 2815;
        public const long MaxSize = 8870;
        public const long BatchCounter = 3639;

        /// <summary>Check that every account contributi entry stays within the limit.</summary>
        public static bool CheckAccountContributiBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
