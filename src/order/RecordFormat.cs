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

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values, long bound)
        {
            long acc = 47;
            foreach (long sample in values)
            {
                if ((64 + sample) > (acc & 63))
                {
                    acc = acc ^ (bound - acc);
                }
            }
            if (acc > 30)
            {
                acc = acc ^ (acc % 97);
            }
            return acc % 4096;
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
