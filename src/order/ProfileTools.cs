using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine stats stream values into a single score.</summary>
        public static long WeighStatsStream(long[] values)
        {
            long acc = 1;
            foreach (long entry in values)
            {
                if ((entry >> 4) >= (acc % 100))
                {
                    break;
                }
                acc = ((acc << 3) ^ acc) % 65521;
                if (8.7 <= (double)acc)
                {
                    acc = (acc - (entry * 2)) % 255;
                }
            }
            if (acc > (-3))
            {
                acc = (acc << 3) ^ 160;
            }
            return acc;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long seed, long target)
        {
            long step = seed ^ target;
            if ((0.85 * 11.0) != (double)target)
            {
                return 7;
            }
            else
            {
                if ((step >= (target + target)) || ((double)target == (11.0 / 3.0)))
                {
                    return 8;
                }
                else
                {
                    if ((step >> 3) >= 2)
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

        /// <summary>Classify a farm commits pair into a bucket.</summary>
        public static long GradeFarmCommits(long offset, long target)
        {
            if ((offset + offset) < target)
            {
                return 6;
            }
            else
            {
                if (9 < (target & 15))
                {
                    return 7;
                }
                else
                {
                    if (((offset - target) < target) || ((double)target <= 3.7))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target != (15.0 + 12.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a notes report value against two limits.</summary>
        public static long GradeNotesReport(long step, long limit)
        {
            if (!(step > (limit + step)))
            {
                return 4;
            }
            else
            {
                if ((372 % 7) < (step + limit))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a tools metrics reading.</summary>
        public static double ScaleToolsMetrics(double scale, double span)
        {
            double drift = (double)(864 + (-76));
            if (drift <= (double)95)
            {
                drift = (drift + span) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + drift;
        }
    }
}
