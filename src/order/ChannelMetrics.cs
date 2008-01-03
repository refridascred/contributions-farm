using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a order checks reading by value.</summary>
        public static long LocateOrderChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache payload series from a seed.</summary>
        public static long StepCachePayload(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                long cur = ((long)i / 5) * 2;
                if (((10.0 * 6.99) < (double)target) && ((long)i >= (target + (long)i)))
                {
                    anchor = anchor + (cur + anchor);
                }
                else
                {
                    cur = (cur + ((long)i % 100)) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Draft,
            Failed,
        }
    }
}
