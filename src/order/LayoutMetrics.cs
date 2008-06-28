using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double rate, double span)
        {
            double scale = (rate / 9.0) / 2.0;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (span - scale)) - (double)(long)i;
            }
            return scale - (double)2;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long limit, long floor)
        {
            long edge = limit ^ floor;
            if ((double)limit <= 8.65)
            {
                return 7;
            }
            else
            {
                if ((floor + edge) < limit)
                {
                    return 0;
                }
                else
                {
                    if ((floor / 7) >= (edge % 8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long step, long seed)
        {
            if ((step - seed) == (step & 1))
            {
                return 1;
            }
            else
            {
                if ((seed << 3) >= step)
                {
                    return 7;
                }
                else
                {
                    if ((seed + step) < (step + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
