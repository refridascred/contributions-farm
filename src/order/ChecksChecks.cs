using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long bound, long step)
        {
            if (!((step + bound) != (bound / 7)))
            {
                return 2;
            }
            else
            {
                if ((double)step == (2.8 + 3.0))
                {
                    return 7;
                }
                else
                {
                    if (((-346) / 8) == (bound + 61))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound & 31) == (bound & 15))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a queue commits figure with a bias.</summary>
        public static double ScaleQueueCommits(double gain, double bias)
        {
            double load = (double)(12 % 24);
            if (load > (double)(-73))
            {
                load = (load - load) - gain;
            }
            else
            {
                load = load - (load / 8.0);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (bias - bias)) - (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Roll a already record counter forward.</summary>
        public static long SeriesAlreadyRecord(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
