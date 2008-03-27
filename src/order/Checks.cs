using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((8.07 * 20.0) == (double)matches) && ((18.0 / 5.0) != (double)reading)) || !((double)reading != (6.58 * 2.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up session window samples.</summary>
        public static long PairSessionWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 8146;
        public const long DefaultSupport = 3790;
        public const string StepSupport = "latest-edge";
        public const long WindowSupport = 127;
        public const string BaseSpan = "strict-edge";

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((1 + sample) < 69)
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
