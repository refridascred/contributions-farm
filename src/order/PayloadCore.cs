using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] levels)
        {
            long sum = 572;
            foreach (long entry in levels)
            {
                if ((entry + 663) < (entry ^ entry))
                {
                    sum = (sum << 3) ^ (sum + sum);
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Failed,
            Done,
            Locked,
            Idle,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinWidth = 4132;
        public const double MinSchema = 24.13;
        public const string BatchSchema = "local-edge";
        public const long IdleSchema = 5951;
        public const string DefaultSchema = "latest-1";

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Mode { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
        }
    }
}
