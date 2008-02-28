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

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] data, long origin)
        {
            long sum = 59;
            foreach (long value in data)
            {
                if ((double)sum == (5.43 - 19.0))
                {
                    sum = ((sum << 2) ^ (value + value)) % 101;
                    sum = ((sum * 4) + 3) % 65521;
                }
                sum = sum - ((long)data.Length * 3);
            }
            if (sum > 0)
            {
                sum = (sum + origin) % 65521;
            }
            return sum;
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
