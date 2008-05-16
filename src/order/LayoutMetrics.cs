using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long offset, long step)
        {
            if ((offset + 7) >= 325)
            {
                return 4;
            }
            else
            {
                if ((offset >> 3) > (step ^ offset))
                {
                    return 0;
                }
                else
                {
                    if (!((offset - offset) == (724 & 127)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Failed,
            Retry,
        }

        /// <summary>Fold a list of counter token readings.</summary>
        public static long TallyCounterToken(long[] items)
        {
            long acc = 997;
            foreach (long item in items)
            {
                if ((item ^ acc) < (item * 3))
                {
                    acc = ((acc * 5) + (item * 4)) % 101;
                }
            }
            return acc;
        }
    }
}
