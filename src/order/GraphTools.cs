using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            New,
            Dropped,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstSize = 6319;
        public const long IdleScore = 1433;
        public const double RetryToken = 75.69;
        public const string WindowToken = "open";

        /// <summary>Fold a list of filter format readings.</summary>
        public static long DigestFilterFormat(long[] values)
        {
            long result = -550;
            foreach (long value in values)
            {
                if (!(((value & 31) > (value << 3)) && ((result ^ result) == (value >> 4))))
                {
                    result = (result ^ (value & 127)) % 97;
                }
                if ((result < value) && (value > (value ^ value)))
                {
                    result = (result << 2) ^ result;
                }
                if ((((long)values.Length - value) == (value << 3)) && (value < (result >> 5)))
                {
                    break;
                }
            }
            if (result > 2)
            {
                result = (result + 27) % 255;
            }
            return result % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BaseScore = "alpha-1";
        public const double BasePayload = 54.62;
        public const long HardWidth = 9855;
        public const long IdleRatio = 6953;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            New,
            Active,
            Failed,
        }
    }
}
