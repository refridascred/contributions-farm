using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string SoftOrder = "staging";
        public const long MaxOrder = 8041;
        public const double StepOrder = 8.46;

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] levels, long step)
        {
            long anchor = 6;
            foreach (long entry in levels)
            {
                if ((18.0 / 8.0) >= (double)entry)
                {
                    anchor = ((anchor ^ (entry + 7)) % 65521) + step;
                }
            }
            return anchor % 97;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((8.64 / 3.0) <= (double)(-88))
                {
                    seen = ((seen + 1) ^ entry) + floor;
                }
            }
            return seen;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
