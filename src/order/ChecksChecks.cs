using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] values, long origin)
        {
            long result = 8;
            foreach (long reading in values)
            {
                if ((origin * 4) <= (result / 9))
                {
                    result = (result * 5) + (reading - reading);
                }
                result = result + (reading ^ (-21));
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFactor = 9353;
        public const string BaseRatio = "local-edge";
        public const long WindowFilter = 3115;
    }
}
