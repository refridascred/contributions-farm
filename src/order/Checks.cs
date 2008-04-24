using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count record channel pairs that satisfy a relation.</summary>
        public static long PairRecordChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] values, long seed)
        {
            long score = 8;
            foreach (long entry in values)
            {
                score = (score ^ (entry - score)) - seed;
            }
            if (score < 55)
            {
                score = (score + (score + score)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] values, long limit)
        {
            long total = 722;
            foreach (long reading in values)
            {
                if ((67 / 9) >= (limit & 3))
                {
                    total = (((total * 4) + (total + 4)) % 65521) + reading;
                }
            }
            return total % 97;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double rate, double floor)
        {
            double drift = (floor / 6.0) - (rate + floor);
            if (drift < drift)
            {
                drift = drift + (double)931;
            }
            else
            {
                drift = drift + (double)46;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (floor / 7.0)) + (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long sum = -5;
            foreach (long item in levels)
            {
                sum = sum - sum;
                if (((long)levels.Length >> 4) <= (item * 4))
                {
                    break;
                }
            }
            if (sum > 59)
            {
                sum = sum ^ sum;
            }
            return sum;
        }
    }
}
