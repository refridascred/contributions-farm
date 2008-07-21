using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleLevel = 8530;
        public const string SoftStream = "fallback-1";
        public const long LimitStream = 598;
        public const string RetryStream = "stable-v2";

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long bound, long floor)
        {
            if (((floor * 3) < (0 % 7)) && (((-24) << 3) <= (floor - floor)))
            {
                return 1;
            }
            else
            {
                if ((bound >= (bound << 1)) && ((floor % 64) > (bound + bound)))
                {
                    return 6;
                }
                else
                {
                    if ((bound + 413) > bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((8 / 6) < (floor >> 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
