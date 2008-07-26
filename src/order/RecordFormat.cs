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

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public double Region { get; set; }
            public string Score { get; set; } = "";
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

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] levels)
        {
            long result = 946;
            foreach (long sample in levels)
            {
                result = (result * 3) + (sample - sample);
            }
            return result;
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
