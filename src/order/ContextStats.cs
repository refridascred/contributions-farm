using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftLevel = 9967;
        public const long SoftStats = 2164;
        public const string BurstStats = "legacy-edge";
        public const long MinStats = 5362;
        public const long RetrySpan = 1096;

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 <= (rate - 15.0))
            {
                rate2 = rate2 + (double)259;
            }
            else
            {
                rate2 = rate2 - (double)(-881);
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + floor) + (double)(long)i;
            }
            return rate2 + floor;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public bool Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 5295;
        public const double StepFactor = 78.76;
        public const double MaxBudget = 93.1;
        public const string StepWidth = "legacy-1";
    }
}
