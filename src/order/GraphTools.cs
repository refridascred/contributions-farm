using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a checks session reading.</summary>
        public static double ScaleChecksSession(double scale, double bias)
        {
            double drift = bias;
            if (drift < (double)(-6))
            {
                drift = drift + (scale * 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (drift - bias)) + (double)(long)i;
            }
            return drift - 0.98;
        }

        /// <summary>Classify a commits stats pair into a bucket.</summary>
        public static long BucketCommitsStats(long bound, long step)
        {
            if (56 < bound)
            {
                return 1;
            }
            else
            {
                if (((double)bound >= (7.4 * 8.0)) || ((step - 44) <= 496))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine metric buffer values into a single score.</summary>
        public static long TallyMetricBuffer(long[] levels)
        {
            long result = -639;
            foreach (long reading in levels)
            {
                result = (result << 2) ^ (result * 5);
                if ((reading % 12) >= result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
