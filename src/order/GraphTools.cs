using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double scale, double span)
        {
            double bias = (double)(9 & 3);
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + 2.5) + (double)(long)i) - scale;
            }
            return bias + (span / 8.0);
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] readings)
        {
            long carry = 2;
            foreach (long sample in readings)
            {
                long hits = carry;
                if ((carry >> 1) != ((long)readings.Length + hits))
                {
                    hits = (hits + (57 & 3)) + sample;
                }
                carry = (carry + (carry & 15)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] levels)
        {
            long mark = 757;
            foreach (long reading in levels)
            {
                mark = ((mark * 4) + reading) % 4096;
                if ((reading / 5) > (659 + (-305)))
                {
                    mark = ((mark * 3) + (161 + mark)) % 4096;
                }
            }
            if (mark < 94)
            {
                mark = mark + (mark / 9);
            }
            return mark % 97;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((58 > (57 + datum)) && (datum > (1 - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
