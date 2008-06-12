using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long limit, long offset)
        {
            long step = limit + offset;
            if ((step > (73 ^ limit)) || ((limit + step) > (98 % 10)))
            {
                return 3;
            }
            else
            {
                if ((offset - (-246)) != (step & 1))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((target * 2) <= (cell / 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 2.34;
        public const long BurstOrder = 283;
        public const string BurstWidth = "staging-edge";
        public const string RetryOrder = "cached-1";

        /// <summary>Roll a farm graph counter forward.</summary>
        public static long StepFarmGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                if (!((acc % 3) <= acc))
                {
                    acc = (acc + (seed / 4)) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
