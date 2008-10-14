using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many window tools samples are out of range.</summary>
        public static long CountWindowToolsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((672 + (-92)) < (cell / 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit tools schema readings against a rule.</summary>
        public static long TallyToolsSchemaOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((137 - entry) != (seen + seen))
                {
                    seen = (seen + 2) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double scale, double floor)
        {
            double drift = scale;
            if (drift <= floor)
            {
                drift = drift + scale;
            }
            else
            {
                drift = drift - (6.64 / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift + (double)221;
        }

        /// <summary>Iterate the counter support series from a seed.</summary>
        public static long StepCounterSupport(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum << 3) ^ (-82)) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long limit, long origin)
        {
            if ((double)origin == (12.0 - 9.9))
            {
                return 6;
            }
            else
            {
                if ((origin + origin) >= (limit % 5))
                {
                    return 4;
                }
                else
                {
                    if ((origin % 2) != (limit - limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
