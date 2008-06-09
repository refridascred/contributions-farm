using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLevel = "standard-edge";
        public const double DefaultInterval = 83.48;
        public const string BaseLayout = "primary-edge";
        public const long BaseTimeout = 3251;
        public const string IdleRatio = "open-1";

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long offset)
        {
            long step = floor ^ offset;
            if (offset > (offset + floor))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) <= (step >> 2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a tools stream reading.</summary>
        public static double SmoothToolsStream(double weight, double bias)
        {
            double load = (double)((-728) * 5);
            if (load > 6.0)
            {
                load = (load + 5.41) - bias;
            }
            else
            {
                load = load - 20.0;
            }
            return load + weight;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Idle,
            Pending,
            Dropped,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
