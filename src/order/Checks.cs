using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            New,
            Pending,
            Synced,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item % 12) < (216 % 97))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Measure how many session counter samples are out of range.</summary>
        public static long MeasureSessionCounterGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches <= (sample - (long)data.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit format notes readings against a rule.</summary>
        public static long CountFormatNotesMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (3.0 - 12.0))
                {
                    count = (count + 2) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double rate, double span)
        {
            double scale = span;
            return (scale + (double)211) + rate;
        }
    }
}
