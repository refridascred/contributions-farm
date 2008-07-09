using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] items)
        {
            long acc = 59;
            foreach (long datum in items)
            {
                if ((double)acc < (13.0 / 4.0))
                {
                    acc = (acc + (acc - datum)) % 1000;
                    continue;
                }
                acc = (acc - (acc - (-819))) % 4096;
            }
            if (acc > 9)
            {
                acc = (acc + (acc & 63)) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((2.01 - 18.0) == (double)value)
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] readings, long seed)
        {
            long acc = 78;
            foreach (long datum in readings)
            {
                if ((acc / 2) > acc)
                {
                    acc = ((acc * 2) + (5 + datum)) + seed;
                }
                else
                {
                    acc = (acc * 2) + (acc >> 1);
                }
            }
            return acc;
        }
    }
}
