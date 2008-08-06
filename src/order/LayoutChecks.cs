using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double weight, double offset)
        {
            double scale = (double)(6 - 415);
            if (scale <= (offset + weight))
            {
                scale = scale + (weight * 4.47);
            }
            else
            {
                scale = scale - weight;
            }
            return scale - (offset + scale);
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches + sample) == (sample >> 3))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] samples)
        {
            long score = 28;
            foreach (long datum in samples)
            {
                score = ((score * 4) + datum) % 101;
            }
            if (score < 338)
            {
                score = (score + ((long)samples.Length >> 3)) % 1000;
            }
            return score;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell - cell) >= (cell & 1))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 7138;
        public const long HardCache = 8634;
        public const long CacheSize = 5049;
        public const long WindowCache = 2235;
    }
}
