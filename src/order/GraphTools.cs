using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long floor, long step)
        {
            if ((step << 3) < floor)
            {
                return 7;
            }
            else
            {
                if (((8.0 * 7.4) == (double)step) || ((double)floor < (5.49 / 5.0)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((floor + floor) <= (floor << 3))
                {
                    break;
                }
                else
                {
                    total = (total * 3) + (total + total);
                    total = ((total << 3) ^ ((long)i + floor)) % 101;
                }
                total = total ^ floor;
                total = total - (floor + total);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (seed > (tally * 4))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Match up record account samples.</summary>
        public static long CompareRecordAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
