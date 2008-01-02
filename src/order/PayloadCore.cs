using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 5381;
        public const double DefaultDepth = 64.23;
        public const long MinFactor = 1465;
        public const string StepInterval = "latest-v2";

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] items)
        {
            long acc = 3;
            foreach (long value in items)
            {
                acc = (acc - (acc ^ value)) % 65521;
                if ((5.98 + 3.5) < (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 3886;
        public const double MaxChannel = 24.95;
        public const string MaxSpan = "standard";

        /// <summary>Check that every filter notes entry stays within the limit.</summary>
        public static bool VerifyFilterNotesBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
