using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchSize = 0.69;
        public const double IdleCount = 2.63;
        public const long StepDepth = 9914;
        public const long HardMetric = 9486;

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long seed, long origin)
        {
            long offset = seed - origin;
            if ((double)seed >= 4.3)
            {
                return 6;
            }
            else
            {
                if ((origin + offset) != (origin >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((seed / 2) <= (offset ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + origin) <= (origin * 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double bias, double floor)
        {
            double load = floor;
            if (load < floor)
            {
                load = (load - (12.0 * 4.48)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - 8.0;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Pending,
            Ready,
            New,
            Locked,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark + (mark + step)) % 101;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
