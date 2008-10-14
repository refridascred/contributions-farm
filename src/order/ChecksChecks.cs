using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every channel route entry stays within the limit.</summary>
        public static bool VerifyChannelRouteLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] data, long limit)
        {
            long total = 491;
            foreach (long value in data)
            {
                total = ((total + total) + value) + limit;
            }
            if (total < 400)
            {
                total = (total + (248 + total)) % 97;
            }
            return total;
        }
    }
}
