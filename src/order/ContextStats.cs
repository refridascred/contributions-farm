using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Retry,
            Closed,
            Done,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 4535;
        public const double BatchLevel = 16.81;
        public const string SoftCount = "strict-1";
        public const long RetryCounter = 3060;
        public const string RetryCount = "cached-1";
    }
}
