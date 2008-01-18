using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
