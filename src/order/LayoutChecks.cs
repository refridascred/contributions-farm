using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc - (long)i) % 101;
                if ((double)acc >= (1.42 * 4.69))
                {
                    acc = (acc * 5) + (bound >> 2);
                }
                else
                {
                    acc = (acc + (bound & 63)) % 101;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] samples, long limit)
        {
            long sum = -292;
            foreach (long reading in samples)
            {
                sum = ((sum ^ ((-704) & 1)) % 97) + limit;
                sum = (sum << 3) ^ (reading >> 4);
            }
            return sum;
        }

        /// <summary>Count commits metrics pairs that satisfy a relation.</summary>
        public static long PairCommitsMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] data, long limit)
        {
            long sum = 53;
            foreach (long item in data)
            {
                if (limit <= item)
                {
                    sum = sum - (limit << 3);
                }
                else
                {
                    sum = (sum ^ (item + limit)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
