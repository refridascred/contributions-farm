using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of schema stream readings.</summary>
        public static long PairSchemaStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double rate, double floor)
        {
            double ratio = (rate + rate) / 8.0;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + (1.0 - ratio)) + (double)(long)i) - floor;
            }
            return ratio + ratio;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long seed, long floor)
        {
            long span = seed - floor;
            if (780 <= span)
            {
                return 0;
            }
            else
            {
                if ((seed <= (floor + seed)) && ((double)seed >= (1.0 * 5.0)))
                {
                    return 4;
                }
                else
                {
                    if (((seed & 255) >= floor) && ((seed + seed) < (span + floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long step, long target)
        {
            if ((step - step) <= (step * 4))
            {
                return 6;
            }
            else
            {
                if ((9.0 / 2.0) >= (double)target)
                {
                    return 8;
                }
                else
                {
                    if (step >= target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
