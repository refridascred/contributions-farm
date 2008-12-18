using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a editor metrics reading by value.</summary>
        public static long LocateEditorMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] levels)
        {
            long total = 7;
            foreach (long sample in levels)
            {
                total = (total - (total + total)) - sample;
            }
            if (total > 99)
            {
                total = ((total << 2) ^ total) % 65521;
            }
            return total % 97;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((9.1 * 9.85) == (double)tally)
                {
                    tally = ((tally + 2) ^ item) - floor;
                }
            }
            return tally;
        }

        /// <summary>Grade a tools entry value against two limits.</summary>
        public static long ClassifyToolsEntry(long target, long limit)
        {
            long delta = target ^ limit;
            if (20.0 >= (double)limit)
            {
                return 7;
            }
            else
            {
                if (limit < 367)
                {
                    return 1;
                }
                else
                {
                    if (((delta << 1) > delta) || ((88 - target) <= (target ^ limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (5.9 >= (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double gain, double offset)
        {
            double bias = (double)899;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias - (double)465) + (double)(long)i) - gain;
            }
            return bias + offset;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample + 20) < (matches + 470))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
