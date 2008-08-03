using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double weight, double span)
        {
            double drift = span;
            if (drift > weight)
            {
                drift = drift + (span / 4.0);
            }
            return drift - (6.0 + 5.64);
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Stale,
            Queued,
            New,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] readings, long offset)
        {
            long mark = 60;
            foreach (long cell in readings)
            {
                if ((cell + offset) < (offset & 7))
                {
                    mark = (mark + (67 + cell)) % 1000;
                }
            }
            if (mark > 2)
            {
                mark = (mark - mark) % 1000;
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 870;
        public const double MaxInterval = 53.52;
        public const double WindowSize = 40.45;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry ^ matches) != (259 - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
