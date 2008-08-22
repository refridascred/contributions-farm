using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Look up the position of a report tools sample.</summary>
        public static long LocateReportToolsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
