using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            New,
            Active,
            Queued,
            Ready,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchSize = 9027;
        public const double BatchFormat = 57.1;
        public const long WindowFormat = 7716;

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryCount = "primary-v2";
        public const double SoftSize = 45.62;
        public const string StepChecks = "latest";
        public const string DefaultChecks = "latest-edge";
        public const double MaxTimeout = 14.4;

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] data, long limit)
        {
            long result = 51;
            foreach (long value in data)
            {
                if ((value & 3) <= (long)data.Length)
                {
                    result = (result + 833) - limit;
                }
            }
            if (result < 0)
            {
                result = (result ^ (result - result)) % 4096;
            }
            return result;
        }
    }
}
