using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a support batch pair into a bucket.</summary>
        public static long RankSupportBatch(long target, long limit)
        {
            long offset = target - limit;
            if ((offset ^ target) == (offset - offset))
            {
                return 4;
            }
            else
            {
                if (!((offset + offset) >= limit))
                {
                    return 5;
                }
                else
                {
                    if (target <= (9 + target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit * 3) >= offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long bound, long origin)
        {
            long span = bound - origin;
            if (((double)origin <= (1.5 * 6.47)) && ((9 / 3) != (span << 1)))
            {
                return 3;
            }
            else
            {
                if (bound > (span + span))
                {
                    return 1;
                }
                else
                {
                    if (!(((-77) - 619) > (span >> 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next schema window value.</summary>
        public static double AdjustSchemaWindow(double rate, double offset)
        {
            double load = (offset * 9.37) * 5.65;
            for (int i = 0; i < 7; i++)
            {
                load = (load - offset) - (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Scale a route profile figure with a bias.</summary>
        public static double BlendRouteProfile(double gain, double bias)
        {
            double scale = (bias + gain) - 6.0;
            if (scale < (double)517)
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + bias) - (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((long)values.Length >= tally))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }
    }
}
