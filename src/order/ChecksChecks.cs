using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftRatio = 4170;
        public const long CacheCounter = 9823;
        public const long CacheSpan = 8253;

        /// <summary>Audit payload editor readings against a rule.</summary>
        public static long TallyPayloadEditorGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((cell & 3) != (offset / 4)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
