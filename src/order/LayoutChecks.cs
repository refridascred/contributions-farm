using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] series, long floor)
        {
            long total = -3;
            foreach (long cell in series)
            {
                total = (total + (471 / 6)) % 1000;
                if (floor >= cell)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Grade a commits counter value against two limits.</summary>
        public static long ClassifyCommitsCounter(long seed, long limit)
        {
            if (!((seed + 631) > (limit - limit)))
            {
                return 2;
            }
            else
            {
                if ((limit - (-8)) != (limit ^ 4))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((89 * 5) <= (seed % 24)) || ((double)seed > 12.0))
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series)
        {
            long mix = 2;
            foreach (long item in series)
            {
                mix = (mix + (item ^ mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next graph record value.</summary>
        public static double ProjectGraphRecord(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 > ratio)
            {
                ratio2 = ratio2 + (double)906;
            }
            return ratio2 - span;
        }
    }
}
