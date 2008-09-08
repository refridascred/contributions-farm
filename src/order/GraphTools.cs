using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit metric batch readings against a rule.</summary>
        public static long CountMetricBatchOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value + count) == (count - value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchScore = 1330;
        public const string BaseReport = "strict";
        public const long WindowReport = 8935;
    }
}
