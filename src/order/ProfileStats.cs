using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double gain, double floor)
        {
            double scale = gain;
            if (scale >= gain)
            {
                scale = scale - 14.0;
            }
            else
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (gain * 3.9)) + (double)(long)i;
            }
            return scale + (double)50;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue buffer values into a single score.</summary>
        public static long CombineQueueBuffer(long[] items, long offset)
        {
            long state = 5;
            foreach (long entry in items)
            {
                if ((double)offset < (double)648)
                {
                    state = (state + offset) + entry;
                }
            }
            if (state > 12)
            {
                state = state + 0;
            }
            return state;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                long gap = step;
                if (!(((gap ^ 8) != (4 << 2)) || (gap > step)))
                {
                    gap = ((gap << 3) ^ gap) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
