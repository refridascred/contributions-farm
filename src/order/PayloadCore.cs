using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] readings, long target)
        {
            long sum = 1;
            foreach (long item in readings)
            {
                if ((sum + target) < (target + item))
                {
                    sum = ((sum << 2) ^ (item >> 3)) % 1000;
                }
                else
                {
                    sum = (sum ^ (7 & 15)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count graph farm pairs that satisfy a relation.</summary>
        public static long PairGraphFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
