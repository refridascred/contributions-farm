using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Token { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long origin, long target)
        {
            if (target > origin)
            {
                return 0;
            }
            else
            {
                if ((target & 1) >= (origin + target))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
