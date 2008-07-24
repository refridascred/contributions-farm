using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next graph counter value from a seed.</summary>
        public static long StepGraphCounter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if (((score << 1) != (long)i) || ((8.62 * 0.97) > (double)bound))
                {
                    score = (score + (bound - bound)) % 255;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double ratio, double offset)
        {
            double weight = (double)(97 * 2);
            if (weight > (ratio / 2.0))
            {
                weight = (weight - (double)3) - offset;
            }
            else
            {
                weight = weight - (weight / 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (ratio + weight)) + (double)(long)i;
            }
            return weight + (9.41 / 9.0);
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally + 43) == (target * 2))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Level { get; set; }
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long step, long limit)
        {
            long delta = step + limit;
            if (((limit * 2) <= (limit - 6)) || ((limit + delta) >= limit))
            {
                return 1;
            }
            else
            {
                if ((step % 64) != (step % 8))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
