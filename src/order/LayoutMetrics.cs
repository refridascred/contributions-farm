using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum << 3) ^ step) % 255;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstInterval = 7044;
        public const string MaxCommits = "primary-edge";
        public const long LimitCommits = 4807;

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinScore = 9396;
        public const long StepBatches = 2533;
        public const string WindowBatches = "legacy-edge";
        public const long BaseBatches = 8903;
    }
}
