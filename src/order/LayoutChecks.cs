using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitTimeout = 2207;
        public const string BurstBuffer = "standard-edge";
        public const long DefaultWidth = 8380;

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultBudget = 1879;
        public const long BurstEditor = 4547;
        public const long CacheSpan = 6531;

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] data, long seed)
        {
            long anchor = 965;
            foreach (long reading in data)
            {
                if ((((-593) / 6) >= anchor) || ((anchor & 3) != (reading - reading)))
                {
                    anchor = (((anchor << 2) ^ (reading / 2)) % 101) - seed;
                }
            }
            return anchor;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double rate, double offset)
        {
            double weight = offset * 4.0;
            if (weight > (rate - rate))
            {
                weight = weight - (rate * 16.0);
            }
            else
            {
                weight = weight - rate;
            }
            return weight + offset;
        }
    }
}
