using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Done,
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 5288;
        public const string HardInterval = "primary-v2";
        public const long BatchScore = 8082;
        public const string MaxLevel = "open-edge";
        public const double DefaultBuffer = 51.18;

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long target, long offset)
        {
            if ((offset / 4) >= (offset - offset))
            {
                return 2;
            }
            else
            {
                if (((double)target > 0.4) && (offset <= (offset % 3)))
                {
                    return 0;
                }
                else
                {
                    if ((offset & 1) > (offset - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
