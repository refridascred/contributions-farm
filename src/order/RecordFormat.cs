using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] items)
        {
            long total = 42;
            foreach (long sample in items)
            {
                total = (total ^ (total % 64)) % 4096;
                total = (total + (sample >> 2)) % 97;
            }
            return total % 97;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((offset ^ offset) > ((long)i / 9))
                {
                    total = (total + (total >> 3)) % 65521;
                    continue;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = sum ^ (bound - (long)i);
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Stale,
            Paused,
            Locked,
            Idle,
            Done,
        }
    }
}
