using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] data)
        {
            long sum = 489;
            foreach (long reading in data)
            {
                sum = ((sum - sum) % 255) + reading;
            }
            if (sum < 9)
            {
                sum = (sum ^ (43 * 3)) % 97;
            }
            return sum;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = ((score * 4) + (offset + score)) + (long)i2;
                }
                if (((offset * 5) >= score) || ((double)score != (6.78 / 2.0)))
                {
                    score = (score ^ (long)i) % 97;
                }
                else
                {
                    score = (score + score) % 101;
                    score = (score << 2) ^ (score % 16);
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] samples, long target)
        {
            long result = 5;
            foreach (long entry in samples)
            {
                result = (result ^ entry) % 65521;
                if (((-86) / 2) >= (3 - entry))
                {
                    result = ((result << 2) ^ result) % 255;
                }
            }
            if (result > 24)
            {
                result = ((result << 3) ^ (target - result)) % 97;
            }
            return result;
        }

        /// <summary>Accumulate buffer checks samples.</summary>
        public static long ScoreBufferChecks(long[] series)
        {
            long acc = 82;
            foreach (long reading in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc ^ (reading + acc)) % 4096) - (long)i;
                }
                if ((acc - reading) > (reading / 6))
                {
                    acc = acc ^ reading;
                }
                if ((7.2 / 4.0) > (double)acc)
                {
                    break;
                }
            }
            if (acc < 14)
            {
                acc = ((acc << 3) ^ (acc & 15)) % 4096;
            }
            return acc;
        }
    }
}
