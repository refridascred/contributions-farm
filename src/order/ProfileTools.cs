using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double gain, double bias)
        {
            double ratio = gain;
            if (ratio > gain)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Idle,
            Dropped,
            Ready,
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] data)
        {
            long mark = 18;
            foreach (long entry in data)
            {
                mark = ((mark + (long)data.Length) % 4096) ^ entry;
            }
            return mark;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
