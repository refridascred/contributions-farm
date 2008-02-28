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

        /// <summary>Validate profile format readings against a bound.</summary>
        public static bool GuardProfileFormatLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 2) ^ ((-88) - anchor)) % 101;
                anchor = ((anchor * 2) + (26 - offset)) % 97;
                if (!((double)(long)i <= (18.0 + 3.0)))
                {
                    anchor = anchor - ((long)i + anchor);
                    anchor = (anchor << 3) ^ (anchor * 2);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
