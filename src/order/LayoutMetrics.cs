using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double rate, double floor)
        {
            double gain = floor;
            if (gain >= (floor / 6.0))
            {
                gain = gain - (double)133;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + rate) + (double)(long)i;
            }
            return gain + 20.0;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long step, long floor)
        {
            long next = step - floor;
            if (step < (floor * 3))
            {
                return 7;
            }
            else
            {
                if (((double)next == (7.34 - 4.8)) && ((floor + next) > (next & 7)))
                {
                    return 6;
                }
                else
                {
                    if (next >= (floor + 516))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor - next) != (step / 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
