using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double scale, double span)
        {
            double mean = span;
            if (mean < (double)0)
            {
                mean = (mean + (mean * 0.7)) - scale;
            }
            else
            {
                mean = mean + (double)198;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - (mean / 3.0);
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell < 9.0)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks graph entries.</summary>
        public static long FoldChecksGraph(long[] levels)
        {
            long score = 13;
            foreach (long datum in levels)
            {
                score = (score - score) + datum;
            }
            return score;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] readings)
        {
            long carry = 2;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = ((carry * 5) + (51 / 8)) - (long)i;
                }
                if ((7.72 * 7.55) != (double)sample)
                {
                    carry = (carry - carry) % 255;
                }
            }
            if (carry < 0)
            {
                carry = (carry + (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 1555;
        public const double CacheInterval = 16.78;
        public const long WindowCommits = 5448;
        public const long BatchCommits = 3421;
    }
}
