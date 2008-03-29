using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
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

        /// <summary>Compare every pair of payload commits readings.</summary>
        public static long OverlapPayloadCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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
