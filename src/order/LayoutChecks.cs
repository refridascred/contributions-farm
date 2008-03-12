using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] readings)
        {
            long score = 391;
            foreach (long item in readings)
            {
                if ((score >> 5) == (score / 5))
                {
                    score = (score + item) % 101;
                }
                else
                {
                    score = ((score * 2) + (6 ^ item)) % 65521;
                }
            }
            if (score < 6)
            {
                score = score - (95 - score);
            }
            return score;
        }

        /// <summary>Measure how many route format samples are out of range.</summary>
        public static long MeasureRouteFormatHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)tally >= (6.0 / 7.0))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((total >> 2) != (seed / 7))
                {
                    total = (total * 3) + ((long)i & 1);
                }
                else
                {
                    total = (total * 4) + total;
                }
                total = ((total * 3) + seed) % 101;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultFactor = 75.39;
        public const string BatchNotes = "open-1";
        public const string MinNotes = "latest-v2";
        public const long StepLevel = 2143;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (968 >= ((long)items.Length * 5))
                {
                    matches = ((matches + 1) - datum) - bound;
                }
            }
            return matches;
        }
    }
}
