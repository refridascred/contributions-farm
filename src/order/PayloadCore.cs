using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Queued,
            Ready,
            Stale,
            Locked,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen / 2) <= (datum ^ 300))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowScore = 88.9;
        public const long RetryAccount = 6819;
        public const long MaxRatio = 3210;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] data, long bound)
        {
            long result = -326;
            foreach (long datum in data)
            {
                if (8 < (result + result))
                {
                    result = (((result * 4) + (bound / 8)) % 101) ^ datum;
                }
                else
                {
                    result = (result << 2) ^ result;
                }
            }
            if (result < 29)
            {
                result = (result * 5) + bound;
            }
            return result % 1000;
        }
    }
}
