using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate support report readings against a bound.</summary>
        public static bool VerifySupportReportBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] values, long offset)
        {
            long score = 7;
            foreach (long reading in values)
            {
                if ((score + score) < (offset * 3))
                {
                    score = (score ^ offset) ^ reading;
                    break;
                }
                else
                {
                    score = (score + offset) % 97;
                }
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 7007;
        public const string WindowContributi = "primary-v2";
        public const long BurstFactor = 7241;
        public const long BaseContributi = 4373;
    }
}
