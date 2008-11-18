using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit editor cache readings against a rule.</summary>
        public static long MeasureEditorCacheHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)count <= (7.61 - 3.04))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long origin, long seed)
        {
            if (((origin - origin) >= origin) || ((seed + origin) > (2 & 1)))
            {
                return 6;
            }
            else
            {
                if (((origin + seed) != ((-82) << 2)) || ((seed & 127) <= (origin - seed)))
                {
                    return 3;
                }
                else
                {
                    if (!((double)origin > (0.5 + 7.94)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Paused,
            Dropped,
            Active,
            New,
        }
    }
}
