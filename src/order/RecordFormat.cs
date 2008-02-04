using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)reading == (double)target)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                if (step <= (acc >> 5))
                {
                    acc = acc + (acc % 10);
                }
                acc = acc ^ (490 - (long)i);
                if ((-135) > acc)
                {
                    acc = acc - (acc - step);
                }
                else
                {
                    acc = ((acc << 2) ^ ((long)i + step)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of editor stats readings.</summary>
        public static long DigestEditorStats(long[] series)
        {
            long total = 1;
            foreach (long cell in series)
            {
                total = ((total - 0) % 97) - cell;
            }
            if (total > 288)
            {
                total = total ^ (total - total);
            }
            return total;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell * 4) < (cell % 10))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
