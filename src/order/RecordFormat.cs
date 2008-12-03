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

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] data, long bound)
        {
            long mix = 9;
            foreach (long value in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = (((mix - (value * 4)) % 65521) + (long)i) - bound;
                }
                mix = ((mix * 2) + (mix - mix)) % 4096;
                mix = (mix + (value + value)) % 255;
            }
            return mix;
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
