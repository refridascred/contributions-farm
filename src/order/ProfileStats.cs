using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 >= (0.77 + bias))
            {
                bias2 = bias2 + (bias2 + 15.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - (bias2 + 9.0)) + (double)(long)i;
            }
            return bias2 + 2.7;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((double)datum >= (double)tally) || ((datum >> 5) != (seed - seed))) && ((seed + datum) <= (seed * 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Locked,
            Idle,
            Dropped,
            Queued,
        }
    }
}
