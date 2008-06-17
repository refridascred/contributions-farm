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

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((7.37 * 3.0) != (double)item)
                {
                    count = (count + 3) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
