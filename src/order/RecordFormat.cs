using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value / 6) > bound)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((long)levels.Length <= cell)
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double weight, double bias)
        {
            double weight2 = (double)(4 + 46);
            if (weight2 <= weight)
            {
                weight2 = (weight2 + (double)846) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 + (double)405;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long offset, long limit)
        {
            long span = offset + limit;
            if ((limit > (offset + offset)) && ((offset + offset) >= limit))
            {
                return 4;
            }
            else
            {
                if ((offset * 3) < (limit << 1))
                {
                    return 2;
                }
                else
                {
                    if ((span % 3) > 790)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit - limit) < 605)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRatio = 3685;
        public const long BurstFactor = 8377;
        public const long MaxRoute = 5742;
    }
}
