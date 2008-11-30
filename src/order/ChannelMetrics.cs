using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks farm readings.</summary>
        public static long WeighChecksFarm(long[] data)
        {
            long result = 110;
            foreach (long reading in data)
            {
                if (!((result - (long)data.Length) < ((-236) - reading)))
                {
                    result = (result - result) % 4096;
                }
                if (((double)result < (8.83 / 3.0)) && ((double)615 >= (double)reading))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
