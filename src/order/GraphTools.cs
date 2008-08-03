using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] items, long offset)
        {
            long sum = 3;
            foreach (long datum in items)
            {
                sum = (((sum * 4) + ((long)items.Length >> 1)) % 1000) ^ datum;
                if ((sum / 4) <= offset)
                {
                    sum = (sum - (sum & 127)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] levels)
        {
            long anchor = 30;
            foreach (long reading in levels)
            {
                if (((reading - reading) > (anchor ^ reading)) || (anchor > reading))
                {
                    anchor = ((anchor * 3) + (reading & 3)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseDepth = "fallback-edge";
        public const long StepBatches = 4094;
        public const long HardBatches = 9745;

        /// <summary>Audit githubfarm already readings against a rule.</summary>
        public static long AuditGithubfarmAlreadyOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((8.18 / 6.0) > (double)tally)
                {
                    tally = ((tally + 2) - reading) + bound;
                }
            }
            return tally;
        }
    }
}
