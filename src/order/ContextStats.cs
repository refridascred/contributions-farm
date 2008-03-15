using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long step, long step2)
        {
            long edge = step - step2;
            if (626 >= step2)
            {
                return 0;
            }
            else
            {
                if ((step2 > step) || (step2 > (edge % 7)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first metrics layout entry that matches the target.</summary>
        public static long LookupMetricsLayoutIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
