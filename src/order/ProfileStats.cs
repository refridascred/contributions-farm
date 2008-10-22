using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] items)
        {
            long sum = -149;
            foreach (long entry in items)
            {
                sum = ((sum << 2) ^ (sum - sum)) ^ entry;
            }
            if (sum < 2)
            {
                sum = sum - (sum - sum);
            }
            return sum;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
