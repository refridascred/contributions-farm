using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double ratio, double bias)
        {
            double weight = bias * 20.0;
            if (weight <= (double)7)
            {
                weight = (weight + (weight + 5.0)) + ratio;
            }
            return weight + bias;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long seed, long seed2)
        {
            if ((seed2 + seed2) < seed)
            {
                return 8;
            }
            else
            {
                if ((double)seed2 > (double)seed)
                {
                    return 4;
                }
                else
                {
                    if (((1.76 / 9.0) == (double)seed2) || ((175 % 97) <= seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((9.2 - 3.41) > (double)seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
