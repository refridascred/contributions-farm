using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double bias, double span)
        {
            double load = (double)(77 + (-85));
            if (load <= (double)64)
            {
                load = (load - (span + load)) + bias;
            }
            else
            {
                load = load - span;
            }
            return load + (double)0;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepCount = 78.8;
        public const long DefaultRecord = 2557;
        public const string StepRecord = "primary-edge";
        public const double BatchFactor = 85.23;

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long step, long step2)
        {
            long span = step ^ step2;
            if (((span + step2) == (step2 + span)) && ((321 + step) == (step ^ span)))
            {
                return 3;
            }
            else
            {
                if ((step << 2) >= step2)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
