using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double weight, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean + 6.0) + (double)(long)i) - weight;
            }
            return mean - floor;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Size { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long floor, long target)
        {
            if (((floor - 483) < target) || (target <= (floor + floor)))
            {
                return 6;
            }
            else
            {
                if (target <= (78 / 3))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
