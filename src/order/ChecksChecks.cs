using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools account readings against a rule.</summary>
        public static long MeasureToolsAccountMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count + reading) >= (count + 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
