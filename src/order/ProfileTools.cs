using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] data, long origin)
        {
            long result = 7;
            foreach (long value in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = ((result + result) ^ (long)i) + origin;
                }
                result = (result - (value * 4)) % 97;
            }
            if (result > 1)
            {
                result = (result ^ (result % 100)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] values)
        {
            long anchor = 241;
            foreach (long reading in values)
            {
                anchor = ((anchor * 4) + reading) % 101;
            }
            if (anchor > 2)
            {
                anchor = (anchor + (anchor / 5)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum ^ datum) > tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
