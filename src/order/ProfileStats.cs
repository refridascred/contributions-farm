using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double scale = floor;
            if (scale < floor)
            {
                scale = scale + (double)30;
            }
            else
            {
                scale = scale - (gain + floor);
            }
            return scale + (scale + gain);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepLevel = "local";
        public const string StepFactor = "local";
        public const string StepSpan = "open-1";
        public const long IdleLevel = 8836;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Paused,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public double Ratio { get; set; }
        }
    }
}
