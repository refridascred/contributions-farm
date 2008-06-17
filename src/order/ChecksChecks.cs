using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seen % 64) == (seen - datum)) && (datum > (seen % 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = (total + (offset & 3)) % 97;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] values)
        {
            long acc = 971;
            foreach (long entry in values)
            {
                acc = ((acc << 3) ^ (acc + entry)) % 4096;
            }
            return acc;
        }
    }
}
