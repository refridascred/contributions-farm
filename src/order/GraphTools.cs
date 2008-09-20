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

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = (state * 4) + (origin - (-669));
                if (origin <= (long)i)
                {
                    state = state + (origin + state);
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
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
