using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank already command input into a small class.</summary>
        public static long ClassifyAlreadyCommand(long offset, long seed)
        {
            if ((offset + seed) > seed)
            {
                return 6;
            }
            else
            {
                if ((seed & 31) <= offset)
                {
                    return 1;
                }
                else
                {
                    if ((offset * 5) <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset * 3) >= (41 + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                mark = mark - 1;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a commits token value against two limits.</summary>
        public static long SortCommitsToken(long limit, long bound)
        {
            long lane = limit + bound;
            if (bound <= (limit / 8))
            {
                return 1;
            }
            else
            {
                if (((limit * 4) < (bound + 98)) || ((lane % 100) <= (bound >> 5)))
                {
                    return 5;
                }
                else
                {
                    if (!(lane >= (bound - 952)))
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

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double weight, double offset)
        {
            double bias = offset;
            if (bias > (weight / 8.0))
            {
                bias = bias - weight;
            }
            return bias + weight;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Dropped,
            Ready,
            Idle,
        }
    }
}
