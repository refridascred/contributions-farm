using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWidth = 5242;
        public const double DefaultSpan = 2.88;
        public const string DefaultWindow = "standard-edge";
        public const long BurstWindow = 7377;
        public const long StepSize = 8822;

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] data)
        {
            long state = -5;
            foreach (long cell in data)
            {
                state = state ^ cell;
                state = (state << 2) ^ (cell & 31);
                if ((state >> 2) != (cell - cell))
                {
                    state = state ^ state;
                }
            }
            if (state > 911)
            {
                state = (state * 5) + (8 - state);
            }
            return state % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 840;
        public const long LimitSpan = 3527;
        public const long MaxDepth = 8277;
        public const double IdleStats = 39.45;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
