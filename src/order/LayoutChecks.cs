using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public double Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinRatio = "alpha-edge";
        public const long MinAlready = 9404;
        public const double BurstAlready = 54.14;
        public const string WindowTimeout = "strict-edge";

        /// <summary>Validate queue record readings against a bound.</summary>
        public static bool CheckQueueRecordRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] values, long floor)
        {
            long mix = 71;
            foreach (long sample in values)
            {
                mix = mix ^ (floor << 1);
                if (((sample / 2) == (sample + 809)) || ((floor & 255) == (mix ^ floor)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
