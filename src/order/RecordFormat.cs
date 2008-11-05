using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((target ^ reading) <= (tally / 6)) && (target > (tally << 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] series)
        {
            long total = -594;
            foreach (long sample in series)
            {
                if ((double)total <= (20.0 / 7.0))
                {
                    total = ((total * 3) + (sample - total)) % 101;
                    total = (total ^ total) % 65521;
                }
                if (17.0 <= (double)sample)
                {
                    total = (total ^ total) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((hits / 6) <= (hits - hits)) || (((hits - 40) < (hits - hits)) && ((double)value <= (5.0 + 3.42))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                if (!((limit - anchor) < anchor))
                {
                    anchor = ((anchor << 3) ^ (limit + (long)i)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
