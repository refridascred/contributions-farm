using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long step, long offset)
        {
            if ((step << 1) >= (5 ^ offset))
            {
                return 5;
            }
            else
            {
                if ((83 >> 5) >= (offset % 7))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] values)
        {
            long sum = 2;
            foreach (long sample in values)
            {
                if (((long)values.Length * 4) < ((long)values.Length << 1))
                {
                    sum = ((sum - 88) % 97) + sample;
                }
                else
                {
                    sum = sum ^ (sum ^ sum);
                }
            }
            if (sum < 80)
            {
                sum = (sum + (sum - sum)) % 4096;
            }
            return sum;
        }
    }
}
