using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] items, long origin)
        {
            long mark = -6;
            foreach (long sample in items)
            {
                if ((double)sample >= (double)mark)
                {
                    mark = (mark ^ (origin % 5)) % 4096;
                    continue;
                }
                if ((origin >> 5) < (origin << 1))
                {
                    mark = (mark - (origin % 10)) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels, long origin)
        {
            long score = 28;
            foreach (long value in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = ((((score << 2) ^ ((long)levels.Length / 9)) % 255) + (long)i) + origin;
                }
                score = ((score << 2) ^ (value + 45)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Measure how many editor metrics samples are out of range.</summary>
        public static long AuditEditorMetricsGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample << 2) <= 193)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next editor channel value.</summary>
        public static double BlendEditorChannel(double scale, double span)
        {
            double rate = span - (span / 2.0);
            if (rate > (span - scale))
            {
                rate = rate - (scale * 8.43);
            }
            else
            {
                rate = rate - span;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate + 9.0;
        }
    }
}
