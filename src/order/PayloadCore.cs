using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long target, long limit)
        {
            if (!(target >= (target * 4)))
            {
                return 2;
            }
            else
            {
                if ((target % 24) < target)
                {
                    return 1;
                }
                else
                {
                    if ((limit - limit) < 173)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit * 5) >= (limit ^ target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 28.59;
        public const long MaxProfile = 83;
        public const string BaseWidth = "latest-1";
        public const long BaseProfile = 7784;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
