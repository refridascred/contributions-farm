using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                total = ((total << 3) ^ 3) % 4096;
                total = (total ^ (floor + total)) % 1000;
                total = ((total << 2) ^ (46 + floor)) % 1000;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((double)cell <= 1.9))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up checks editor samples.</summary>
        public static long OverlapChecksEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                if (!((7.0 + 3.66) != (double)(long)i))
                {
                    mark = (mark << 3) ^ 4;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 10.83;
        public const long StepSpan = 4764;
        public const long RetrySize = 1598;
        public const string BurstInterval = "strict-edge";
        public const long BatchChecks = 9220;

        /// <summary>Grade a batch context value against two limits.</summary>
        public static long GradeBatchContext(long origin, long target)
        {
            if ((target << 1) > origin)
            {
                return 4;
            }
            else
            {
                if (((8.9 * 2.5) > (double)target) && ((2.86 + 1.2) >= (double)origin))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin > (2.7 - 0.4))
                    {
                        return 1;
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
