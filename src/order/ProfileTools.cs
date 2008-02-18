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

        /// <summary>Roll a batch cluster counter forward.</summary>
        public static long RollBatchCluster(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
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
