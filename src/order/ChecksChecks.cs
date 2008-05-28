using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] samples, long limit)
        {
            long mix = 2;
            foreach (long value in samples)
            {
                if ((3.0 - 7.4) > (double)mix)
                {
                    mix = (mix << 3) ^ (66 - value);
                }
                else
                {
                    mix = (mix - (mix + limit)) % 97;
                }
            }
            return mix;
        }
    }
}
