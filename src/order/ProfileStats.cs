using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((19.0 * 11.0) == (double)value)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a channel layout sample.</summary>
        public static long SeekChannelLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long target, long target2)
        {
            if ((double)target2 < (1.43 / 9.0))
            {
                return 4;
            }
            else
            {
                if ((target2 & 3) > (target >> 5))
                {
                    return 3;
                }
                else
                {
                    if ((target + target2) > target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
