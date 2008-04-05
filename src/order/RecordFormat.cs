using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] samples)
        {
            long result = 3;
            foreach (long item in samples)
            {
                if (((item / 5) <= (88 % 8)) || (((-63) ^ result) > item))
                {
                    result = ((result * 4) + item) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                if (((double)mark > 6.0) && ((2 - 766) >= (mark + mark)))
                {
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Compare every pair of stats batch readings.</summary>
        public static long CompareStatsBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit session tools readings against a rule.</summary>
        public static long AuditSessionToolsGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (bound >= (item * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum > (datum ^ hits)) && (((datum & 1) < (hits & 1)) || ((datum << 3) > hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
