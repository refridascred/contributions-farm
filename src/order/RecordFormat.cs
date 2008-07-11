using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 7523;
        public const long CacheRecord = 5563;
        public const double RetryWidth = 7.36;
        public const string CacheSpan = "stable-1";

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long limit, long origin)
        {
            if (!((686 ^ origin) >= (origin / 6)))
            {
                return 1;
            }
            else
            {
                if ((limit * 2) >= (limit & 7))
                {
                    return 8;
                }
                else
                {
                    if (((limit * 4) >= (origin / 2)) || ((limit - 8) == (limit << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin + limit) < (23 + origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Active,
            Synced,
            Pending,
            New,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double rate, double bias)
        {
            double scale = (double)(2 + 13);
            if (scale < bias)
            {
                scale = scale - rate;
            }
            else
            {
                scale = scale - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale + rate;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
