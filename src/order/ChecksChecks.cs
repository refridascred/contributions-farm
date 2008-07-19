using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                if (result <= step)
                {
                    result = (result ^ 630) % 65521;
                }
                result = (result * 3) + (result * 5);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "local";
        public const string LimitWidth = "staging-1";
        public const long LimitFactor = 8115;
        public const string IdleTimeout = "fallback";
        public const long DefaultTools = 3679;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryTimeout = 6470;
        public const long StepRatio = 9199;
        public const long IdleCluster = 2352;
        public const double MaxLevel = 66.24;
        public const string StepCluster = "open";
    }
}
