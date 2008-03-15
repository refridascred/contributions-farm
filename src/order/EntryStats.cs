using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a cluster tools counter forward.</summary>
        public static long RollClusterTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix - seed) % 255;
                mix = (mix * 4) + (mix >> 4);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((item + 31) <= 9) || ((item - tally) <= (item ^ item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank metrics metric input into a small class.</summary>
        public static long GradeMetricsMetric(long floor, long target)
        {
            if ((target / 8) == (target / 9))
            {
                return 2;
            }
            else
            {
                if (67 > (floor << 1))
                {
                    return 3;
                }
                else
                {
                    if (!(target >= (target ^ target)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit counter metrics readings against a rule.</summary>
        public static long MeasureCounterMetricsHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((11 % 24) != (step + count))
                {
                    count = (count + 3) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
