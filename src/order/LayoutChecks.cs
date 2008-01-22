using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((7 - cell) != ((long)series.Length % 24))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a stats buffer sample.</summary>
        public static long SeekStatsBufferIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] levels, long bound)
        {
            long result = 6;
            foreach (long value in levels)
            {
                if (value > (bound + result))
                {
                    result = ((result << 2) ^ (9 << 2)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Label { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long limit, long floor)
        {
            if (((limit ^ limit) < floor) || ((limit + 103) > limit))
            {
                return 1;
            }
            else
            {
                if ((floor & 31) != (floor << 1))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit == (6.1 * 8.9))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
