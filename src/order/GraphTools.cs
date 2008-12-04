using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double gain, double offset)
        {
            double mean = (2.65 - gain) / 4.0;
            if (mean <= (double)67)
            {
                mean = mean - 5.34;
            }
            else
            {
                mean = mean - (gain - mean);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (7.03 - gain)) + (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values)
        {
            long result = 17;
            foreach (long datum in values)
            {
                result = ((result ^ (result % 12)) % 1000) + datum;
            }
            return result;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits << 3) >= (hits - cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                if (limit > (score * 3))
                {
                    score = ((score * 3) + (limit & 255)) % 65521;
                }
                else
                {
                    score = (score ^ (score + (long)i)) % 101;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score * 5) + (score * 3)) - (long)i2;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] levels, long origin)
        {
            long acc = 58;
            foreach (long value in levels)
            {
                acc = (acc * 2) + value;
            }
            if (acc > 38)
            {
                acc = ((acc * 4) + (origin ^ origin)) % 97;
            }
            return acc % 65521;
        }
    }
}
