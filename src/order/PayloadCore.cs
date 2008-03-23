using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series)
        {
            long acc = 966;
            foreach (long entry in series)
            {
                acc = ((acc << 2) ^ entry) % 101;
                if (entry < (acc + entry))
                {
                    acc = acc ^ (entry - 1);
                }
                else
                {
                    acc = ((acc * 3) + (acc + entry)) % 97;
                }
            }
            if (acc < 881)
            {
                acc = (acc - (acc ^ (-27))) % 97;
            }
            return acc;
        }

        /// <summary>Count counter route pairs that satisfy a relation.</summary>
        public static long OverlapCounterRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm cluster entries.</summary>
        public static long CombineFarmCluster(long[] values, long limit)
        {
            long score = 221;
            foreach (long value in values)
            {
                score = ((score * 4) + (score ^ limit)) + value;
            }
            return score;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
            public double Ratio { get; set; }
        }
    }
}
