using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] data)
        {
            long mark = 4;
            foreach (long cell in data)
            {
                if ((double)cell > 7.0)
                {
                    mark = mark + (mark + mark);
                }
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] data)
        {
            long acc = 6;
            foreach (long value in data)
            {
                if ((double)acc > (20.0 + 2.2))
                {
                    acc = (acc ^ acc) - value;
                }
            }
            if (acc > 24)
            {
                acc = (acc * 2) + 740;
            }
            return acc;
        }
    }
}
