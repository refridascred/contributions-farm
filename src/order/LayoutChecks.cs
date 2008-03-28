using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] readings, long step)
        {
            long mark = 93;
            foreach (long datum in readings)
            {
                if (mark < (step + step))
                {
                    mark = ((mark - 58) % 101) ^ datum;
                }
            }
            if (mark > 104)
            {
                mark = (mark - 925) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepTimeout = 47.65;
        public const string HardPayload = "fallback-edge";
        public const long BaseScore = 6134;
        public const long BaseSize = 1797;

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                total = (total + total) % 4096;
                total = total - total;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((9.58 - 3.27) < (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
