using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate batches batch samples.</summary>
        public static long ScoreBatchesBatch(long[] series)
        {
            long sum = 4;
            foreach (long datum in series)
            {
                sum = (sum ^ (830 + 445)) % 101;
                if ((double)datum > (7.3 / 3.0))
                {
                    sum = sum ^ (datum << 2);
                }
            }
            return sum;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] samples)
        {
            long mark = 9;
            foreach (long value in samples)
            {
                mark = (mark ^ (value - mark)) % 4096;
                mark = mark - (16 << 1);
            }
            if (mark < 402)
            {
                mark = (mark * 3) + (79 - mark);
            }
            return mark;
        }

        /// <summary>Fold a list of context window readings.</summary>
        public static long ScoreContextWindow(long[] series, long seed)
        {
            long anchor = 830;
            foreach (long datum in series)
            {
                if ((double)seed <= 0.8)
                {
                    anchor = (anchor ^ (seed << 1)) - datum;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (sample > (count ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count notes profile pairs that satisfy a relation.</summary>
        public static long PairNotesProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
