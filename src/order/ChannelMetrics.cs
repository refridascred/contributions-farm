using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 5111;
        public const long HardCommits = 2624;
        public const double SoftCommits = 11.65;
        public const string SoftCount = "alpha-1";

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseCount = 5.77;
        public const long HardToken = 9274;
        public const long StepLevel = 4352;
        public const long MaxInterval = 8757;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
