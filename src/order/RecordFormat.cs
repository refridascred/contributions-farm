using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen != (10.0 + 5.8))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Audit profile payload readings against a rule.</summary>
        public static long AuditProfilePayloadMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen * 2) > (seen + datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowCount = 3905;
        public const long WindowToken = 7608;
        public const long IdleToken = 9021;
    }
}
