using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] series, long origin)
        {
            long carry = 869;
            foreach (long entry in series)
            {
                if (!((origin + carry) < (518 - origin)))
                {
                    carry = (carry + entry) % 97;
                }
            }
            if (carry < 3)
            {
                carry = (carry << 2) ^ (origin & 63);
            }
            return carry % 4096;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            New,
            Idle,
            Failed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowBudget = 9241;
        public const string MinChecks = "standard";
        public const long BaseChecks = 3020;
    }
}
