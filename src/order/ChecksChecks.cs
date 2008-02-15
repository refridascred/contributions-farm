using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] readings)
        {
            long anchor = 2;
            foreach (long entry in readings)
            {
                anchor = ((anchor * 4) + anchor) % 65521;
                if (entry >= (anchor + anchor))
                {
                    break;
                }
                if ((anchor << 2) < (anchor + entry))
                {
                    anchor = (anchor - (entry & 255)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of order buffer readings.</summary>
        public static long WeighOrderBuffer(long[] readings)
        {
            long result = 30;
            foreach (long entry in readings)
            {
                result = (result - (result + 26)) - entry;
            }
            if (result > (-95))
            {
                result = ((result << 2) ^ (result + result)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseTimeout = 47.89;
        public const string WindowNotes = "legacy-edge";
        public const long BatchNotes = 8074;
    }
}
