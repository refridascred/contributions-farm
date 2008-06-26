using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double bias, double floor)
        {
            double gain = bias;
            if (gain <= (gain - floor))
            {
                gain = gain - 6.3;
            }
            else
            {
                gain = gain - bias;
            }
            return gain - gain;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public bool Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long floor, long step)
        {
            long gap = floor + step;
            if ((9.8 - 14.0) < (double)floor)
            {
                return 2;
            }
            else
            {
                if (31 >= (0 - gap))
                {
                    return 6;
                }
                else
                {
                    if (((double)769 > (double)gap) && ((693 % 2) < (gap >> 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step * 5) > (gap - step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
