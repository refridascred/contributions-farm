using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double bias, double bias2)
        {
            double load = bias2;
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 1572;
        public const long StepPayload = 4740;
        public const long LimitRatio = 6623;
        public const long MaxPayload = 8479;
        public const string DefaultPayload = "local-1";

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Failed,
            Dropped,
            Done,
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
