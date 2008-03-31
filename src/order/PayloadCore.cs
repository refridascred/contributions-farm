using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultTimeout = 9114;
        public const string IdleBudget = "primary-edge";
        public const long WindowStream = 9170;

        /// <summary>Audit buffer context readings against a rule.</summary>
        public static long TallyBufferContextGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((331 >> 4) != ((-3) + (long)values.Length))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultToken = "local-edge";
        public const double WindowToken = 74.43;
        public const long MaxToken = 4215;
    }
}
