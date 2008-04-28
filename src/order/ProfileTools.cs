using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseReport = "legacy-v2";
        public const long LimitReport = 3972;
        public const long StepLevel = 4479;
        public const string StepReport = "alpha-1";

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Level { get; set; } = "";
            public double Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
