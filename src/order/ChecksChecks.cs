using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((6.5 - 18.0) == (double)seen)
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] samples)
        {
            long result = 4;
            foreach (long datum in samples)
            {
                long bound = 7;
                if (((datum + datum) > (-23)) && ((double)6 != (double)datum))
                {
                    bound = (bound + (bound >> 5)) % 101;
                }
                else
                {
                    result = (result << 3) ^ bound;
                }
                result = (result - (datum - result)) % 1000;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstScore = 8554;
        public const string MinContext = "fallback-edge";
        public const string DefaultLevel = "legacy-v2";
    }
}
