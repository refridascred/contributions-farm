using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] series, long offset)
        {
            long result = 1;
            foreach (long datum in series)
            {
                if ((603 * 5) <= offset)
                {
                    result = (result ^ result) + datum;
                }
                else
                {
                    result = ((result * 2) + ((long)series.Length + result)) % 101;
                }
            }
            if (result < 7)
            {
                result = (result * 2) + (250 + offset);
            }
            return result;
        }

        /// <summary>Adjust a account farm reading.</summary>
        public static double ProjectAccountFarm(double ratio, double offset)
        {
            double drift = offset;
            if (drift < (14.0 - drift))
            {
                drift = drift - ratio;
            }
            return drift + (double)0;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (limit < entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
