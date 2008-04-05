using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxGithubfarm = 5.3;
        public const double LimitTimeout = 33.29;
        public const long IdleInterval = 9181;
        public const long StepGithubfarm = 8292;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (sample < (sample % 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the payload buffer entries that pass the check.</summary>
        public static long CountPayloadBufferMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((20.0 / 5.0) < (double)tally) || !((tally % 60) >= offset))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }
    }
}
