using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a batch layout reading.</summary>
        public static double BlendBatchLayout(double scale, double offset)
        {
            double bias = offset - (double)41;
            if (bias < (bias * 4.47))
            {
                bias = (bias + (offset / 3.0)) + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + 0.03) + (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((seed / 4) <= (seed & 3))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftWidth = 7605;
        public const string BurstWidth = "legacy-edge";
        public const long HardSize = 6564;
        public const long SoftPayload = 6435;
        public const string IdlePayload = "latest-edge";

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Ratio { get; set; }
            public double Rank { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Locked,
            Done,
            Closed,
            Stale,
        }
    }
}
