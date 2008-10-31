using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long step, long bound)
        {
            if (step >= (bound - bound))
            {
                return 6;
            }
            else
            {
                if ((bound * 2) <= bound)
                {
                    return 4;
                }
                else
                {
                    if ((bound ^ bound) <= (step - step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double weight, double offset)
        {
            double ratio = (double)(6 * 3);
            if (ratio > (weight * 9.3))
            {
                ratio = (ratio - weight) + offset;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - 4.01) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Iterate the entry batches series from a seed.</summary>
        public static long RollEntryBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor ^ ((long)i >> 3)) % 101;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((double)seed != (double)acc)
                {
                    acc = acc + (acc + (long)i);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 5; i++)
            {
                if (!(target < (target + target)))
                {
                    score = (score - (long)i) % 1000;
                    score = score + (long)i;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
