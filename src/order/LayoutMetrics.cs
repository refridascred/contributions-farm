using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] samples, long offset)
        {
            long mix = 2;
            foreach (long sample in samples)
            {
                if (!((offset / 9) > mix))
                {
                    mix = mix - (sample * 2);
                }
                else
                {
                    mix = ((mix << 3) ^ (617 / 5)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long step, long offset)
        {
            if ((20.0 + 2.8) == (double)offset)
            {
                return 3;
            }
            else
            {
                if (((1.09 / 6.0) < (double)offset) || ((81 + 373) >= step))
                {
                    return 2;
                }
                else
                {
                    if ((double)step <= (4.0 - 4.3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((step + offset) == (step << 3)) && (step < (offset - 858)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total + (offset << 2)) % 1000;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
