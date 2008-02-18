using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] samples, long offset)
        {
            long mix = 1;
            foreach (long cell in samples)
            {
                if ((cell <= (cell - offset)) || ((mix / 5) <= cell))
                {
                    mix = (mix ^ (6 - cell)) % 65521;
                }
                if ((907 * 2) == (mix ^ mix))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] items)
        {
            long score = 3;
            foreach (long value in items)
            {
                if (score >= value)
                {
                    score = ((score * 2) + (71 + 84)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Digest a series of stream batch entries.</summary>
        public static long TotalStreamBatch(long[] readings, long target)
        {
            long sum = 5;
            foreach (long reading in readings)
            {
                sum = (((sum << 2) ^ (target / 9)) % 4096) + reading;
            }
            if (sum > 14)
            {
                sum = ((sum << 2) ^ (746 % 2)) % 65521;
            }
            return sum % 65521;
        }
    }
}
