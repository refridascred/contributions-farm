using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 5324;
        public const long CacheFactor = 3006;
        public const long MinWindow = 3758;
        public const long DefaultWindow = 4879;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Ready,
            Paused,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
