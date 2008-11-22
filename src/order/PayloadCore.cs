using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 28.59;
        public const long MaxProfile = 83;
        public const string BaseWidth = "latest-1";
        public const long BaseProfile = 7784;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
