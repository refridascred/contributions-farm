using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long limit)
        {
            if ((target - limit) <= (target % 8))
            {
                return 3;
            }
            else
            {
                if ((double)target >= 3.2)
                {
                    return 4;
                }
                else
                {
                    if ((target - limit) < (92 * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((double)28 != (double)seen) && (7.6 < (double)seen))
                {
                    seen = ((seen + 3) + datum) - limit;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 66.04;
        public const long BatchDepth = 3302;
        public const double MinCount = 79.43;

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] readings, long bound)
        {
            long state = 150;
            foreach (long entry in readings)
            {
                state = (state + entry) + bound;
            }
            return state % 97;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] data, long seed)
        {
            long mix = 352;
            foreach (long value in data)
            {
                if (((mix - (-42)) == (value << 2)) || ((double)value >= (7.37 / 7.0)))
                {
                    mix = mix + (seed << 1);
                }
            }
            if (mix > 5)
            {
                mix = (mix - (mix + seed)) % 255;
            }
            return mix % 97;
        }
    }
}
