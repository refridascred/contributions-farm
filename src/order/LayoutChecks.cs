using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc << 3) ^ (long)i) % 97;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every already counter entry stays within the limit.</summary>
        public static bool GuardAlreadyCounterLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the format batches entries that pass the check.</summary>
        public static long AuditFormatBatchesGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((8 + seen) > (datum << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                score = ((score << 3) ^ ((long)i + score)) % 101;
                for (int i3 = 0; i3 < 11; i3++)
                {
                    score = ((score - (score / 8)) % 97) ^ (long)i3;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
