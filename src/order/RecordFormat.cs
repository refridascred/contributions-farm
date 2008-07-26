using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] samples)
        {
            long acc = 0;
            foreach (long reading in samples)
            {
                if (reading > acc)
                {
                    acc = ((acc << 3) ^ acc) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double scale, double offset)
        {
            double gain = (offset - 9.9) + (6.9 / 4.0);
            if (gain <= scale)
            {
                gain = gain + (double)0;
            }
            return gain - 4.9;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(entry <= 52))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches githubfarm samples are out of range.</summary>
        public static long MeasureBatchesGithubfarmHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!(((matches * 2) >= (matches >> 3)) && (2 <= (step + matches))))
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
