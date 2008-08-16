using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of tools report entries.</summary>
        public static long ScoreToolsReport(long[] readings, long target)
        {
            long mix = 57;
            foreach (long sample in readings)
            {
                mix = ((mix * 5) + (mix * 3)) % 4096;
                mix = mix ^ (target + target);
                mix = mix + (sample ^ target);
            }
            return mix % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstNotes = 84.99;
        public const double DefaultNotes = 53.39;
        public const long MinNotes = 7261;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item > (5.7 * 7.85))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the notes metric entries that pass the check.</summary>
        public static long MeasureNotesMetricOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches + matches) <= cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
