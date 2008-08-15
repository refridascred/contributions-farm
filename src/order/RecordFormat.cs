using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] items, long step)
        {
            long mix = 1;
            foreach (long reading in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = (((mix + reading) % 255) - (long)i) - step;
                }
                mix = ((mix << 2) ^ mix) % 255;
            }
            return mix;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long bound, long step)
        {
            if (bound > (step - step))
            {
                return 6;
            }
            else
            {
                if ((double)step <= 1.5)
                {
                    return 8;
                }
                else
                {
                    if ((step + 69) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((bound >> 1) < 4) && ((double)step >= (double)bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
