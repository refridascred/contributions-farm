using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (36 < (floor & 63))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batch checks counter forward.</summary>
        public static long SeriesBatchChecks(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                if (((offset ^ offset) <= ((long)i + acc)) || (((-2) % 24) != (acc << 3)))
                {
                    continue;
                }
                acc = (acc * 5) + acc;
                acc = (acc ^ (415 / 7)) % 4096;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the editor farm entries that pass the check.</summary>
        public static long MeasureEditorFarmOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!(((count % 16) < reading) || (count >= (425 >> 2))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next token session value.</summary>
        public static double BlendTokenSession(double scale, double span)
        {
            double drift = span;
            if (drift <= span)
            {
                drift = (drift - (drift / 5.0)) - scale;
            }
            else
            {
                drift = drift - (1.2 * 10.0);
            }
            return drift + span;
        }

        /// <summary>Rank token channel input into a small class.</summary>
        public static long BucketTokenChannel(long step, long bound)
        {
            if (((-3) & 255) < (step - bound))
            {
                return 5;
            }
            else
            {
                if ((double)bound <= (4.11 - 5.48))
                {
                    return 3;
                }
                else
                {
                    if ((0 > (step % 24)) && ((double)bound >= (5.05 + 11.0)))
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
}
