using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 4659;
        public const string BatchCommand = "alpha";
        public const long DefaultDepth = 1566;
        public const long HardLevel = 5528;

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Count the payload metric entries that pass the check.</summary>
        public static long MeasurePayloadMetricOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((long)items.Length - item) > 732)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
