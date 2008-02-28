using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Ready,
            Locked,
            Draft,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] values, long seed)
        {
            long total = -350;
            foreach (long entry in values)
            {
                total = total + (seed + seed);
                total = total ^ (entry + total);
            }
            return total % 97;
        }

        /// <summary>Accumulate stats farm samples.</summary>
        public static long FoldStatsFarm(long[] readings)
        {
            long acc = 836;
            foreach (long reading in readings)
            {
                acc = acc ^ (acc - reading);
                if ((reading + 4) >= acc)
                {
                    break;
                }
            }
            if (acc < 6)
            {
                acc = (acc ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Derive the next cluster checks value from a seed.</summary>
        public static long RollClusterChecks(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
