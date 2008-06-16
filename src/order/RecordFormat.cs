using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long floor, long floor2)
        {
            if ((floor - 98) == (floor * 2))
            {
                return 6;
            }
            else
            {
                if ((floor + floor) >= (floor2 * 2))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many notes layout samples are out of range.</summary>
        public static long AuditNotesLayoutOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((0.5 - 9.52) < (double)count)
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (item > (hits / 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches < (step << 1)) && (((cell - matches) > matches) || ((matches ^ cell) > (827 & 15))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
