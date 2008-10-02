using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a commits githubfarm figure with a bias.</summary>
        public static double ScaleCommitsGithubfarm(double gain, double offset)
        {
            double scale = (double)((-940) - 30);
            if (scale <= (double)8)
            {
                scale = (scale + scale) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (11.0 * 6.19)) + (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Score { get; set; }
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long bound, long seed)
        {
            long cur = bound - seed;
            if ((double)cur > 8.18)
            {
                return 7;
            }
            else
            {
                if ((4.0 - 12.0) >= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (!((bound >> 4) < (3 ^ bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((cur * 4) >= (bound / 2)) || (seed > (bound - 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
