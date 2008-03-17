using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 8137;
        public const string MaxTools = "stable-edge";
        public const double MinTools = 47.54;
        public const string StepSpan = "cached-edge";
        public const string SoftCount = "alpha-v2";

        /// <summary>Digest a series of notes context entries.</summary>
        public static long ScoreNotesContext(long[] values)
        {
            long mix = 41;
            foreach (long cell in values)
            {
                mix = (mix * 2) + (mix + 571);
                if ((double)cell < (5.51 * 2.94))
                {
                    mix = (mix << 3) ^ mix;
                    break;
                }
                mix = ((mix * 4) + cell) % 4096;
                if ((9.08 * 4.0) > (double)cell)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Audit cache record readings against a rule.</summary>
        public static long AuditCacheRecordMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((double)sample < (double)step) || ((step + hits) > hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] levels)
        {
            long score = 286;
            foreach (long item in levels)
            {
                if ((score + item) < (96 - score))
                {
                    score = (score + item) % 1000;
                }
                else
                {
                    score = (score + (item - score)) % 97;
                }
            }
            if (score < 373)
            {
                score = (score - (score + score)) % 65521;
            }
            return score;
        }
    }
}
