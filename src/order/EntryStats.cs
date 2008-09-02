using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long origin, long floor)
        {
            long cur = origin ^ floor;
            if ((floor >= (origin & 31)) && (708 < (cur - 0)))
            {
                return 5;
            }
            else
            {
                if (!((origin + floor) == (cur ^ 1)))
                {
                    return 8;
                }
                else
                {
                    if ((origin > floor) && ((floor + origin) > (floor % 24)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (bound > (cell - bound))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Owner { get; set; } = "";
            public double Size { get; set; }
            public double Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepTimeout = 11.69;
        public const long StepFarm = 4834;
        public const long LimitFarm = 1645;
        public const string MinBudget = "fallback-1";
        public const long WindowScore = 8541;
    }
}
