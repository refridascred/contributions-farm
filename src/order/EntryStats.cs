using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long offset, long offset2)
        {
            if ((double)offset2 <= 11.0)
            {
                return 6;
            }
            else
            {
                if ((3.0 - 5.6) > (double)offset2)
                {
                    return 3;
                }
                else
                {
                    if ((offset + offset2) < (offset % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Adjust a notes record reading.</summary>
        public static double AdjustNotesRecord(double gain, double span)
        {
            double ratio = gain;
            if (ratio > (double)(-3))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - span;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (ratio / 8.0)) + (double)(long)i;
            }
            return ratio - (ratio * 3.0);
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix << 2) ^ step) % 255;
                mix = mix - (mix - (long)i);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
