using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a cluster batches counter forward.</summary>
        public static long RollClusterBatches(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((450 - floor) == (6 - score))
                {
                    score = (score * 5) + (floor % 100);
                    score = (score * 5) + (floor - floor);
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 97.57;
        public const long StepInterval = 6762;
        public const long StepFactor = 2954;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long offset, long target)
        {
            if (((offset - offset) <= (offset % 100)) || ((offset << 1) <= (offset - target)))
            {
                return 4;
            }
            else
            {
                if ((offset ^ 7) != (offset + target))
                {
                    return 6;
                }
                else
                {
                    if (((99 << 1) > (target >> 5)) && (9.45 <= (double)target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((1.9 / 3.0) == (double)offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((origin / 5) <= (datum / 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double weight, double floor)
        {
            double drift = (1.39 / 8.0) / 5.0;
            if (drift > weight)
            {
                drift = drift + (double)914;
            }
            return drift - (floor / 9.0);
        }
    }
}
