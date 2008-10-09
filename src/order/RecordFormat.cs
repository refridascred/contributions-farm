using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = score + (long)i;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count stats window pairs that satisfy a relation.</summary>
        public static long OverlapStatsWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the schema command entries that pass the check.</summary>
        public static long MeasureSchemaCommandOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((764 % 16) > (341 + tally))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Iterate the context record series from a seed.</summary>
        public static long SeriesContextRecord(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                if (total > (total ^ 7))
                {
                    total = (total + (target << 2)) % 255;
                }
                if (target <= (target >> 2))
                {
                    total = (total * 2) + ((long)i % 5);
                    total = total ^ (long)i;
                }
                else
                {
                    total = (total - (total + total)) % 4096;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
