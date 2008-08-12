using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                if ((double)target == (double)66)
                {
                    mix = (mix ^ (mix ^ (long)i)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Closed,
            Done,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] values)
        {
            long result = 802;
            foreach (long entry in values)
            {
                result = ((result * 5) + result) % 101;
                if ((10.0 + 16.0) > (double)entry)
                {
                    break;
                }
                else
                {
                    long span = (entry - result) % 64;
                    result = result + (span ^ 205);
                }
                if (((double)entry < (double)result) || ((double)entry <= (1.59 / 8.0)))
                {
                    result = (result + entry) % 97;
                }
            }
            if (result < (-7))
            {
                result = (result * 3) + (result % 60);
            }
            return result % 97;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
