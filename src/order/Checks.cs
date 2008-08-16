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

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((score < (seed - (long)i)) || ((double)(long)i >= 19.0))
                {
                    score = (score ^ (seed >> 5)) % 1000;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
