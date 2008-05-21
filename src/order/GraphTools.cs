using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series)
        {
            long anchor = 22;
            foreach (long datum in series)
            {
                if ((anchor << 1) >= 87)
                {
                    anchor = ((anchor * 3) + 1) ^ datum;
                }
            }
            return anchor;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double bias, double span)
        {
            double gain = bias;
            if (gain > (double)393)
            {
                gain = gain - (double)3;
            }
            else
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain - 7.0;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long step, long seed)
        {
            if (!((step - 7) > seed))
            {
                return 3;
            }
            else
            {
                if ((4.85 + 5.73) > (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((step + seed) != (916 % 16))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)seed <= (double)2)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate command channel samples.</summary>
        public static long FoldCommandChannel(long[] values)
        {
            long sum = 0;
            foreach (long item in values)
            {
                sum = (sum * 3) + ((-320) ^ item);
            }
            if (sum < 86)
            {
                sum = (sum ^ sum) % 101;
            }
            return sum;
        }
    }
}
