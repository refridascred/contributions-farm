using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long origin, long floor)
        {
            if ((double)origin != (double)floor)
            {
                return 8;
            }
            else
            {
                if ((double)9 >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
