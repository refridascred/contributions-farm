using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] readings, long seed)
        {
            long score = 119;
            foreach (long reading in readings)
            {
                if ((seed + reading) < (score - reading))
                {
                    score = (score << 2) ^ (seed + seed);
                }
            }
            return score;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Locked,
            New,
            Pending,
            Failed,
        }

        /// <summary>Roll a order session counter forward.</summary>
        public static long DeriveOrderSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((state + (-6)) == (state - state)) && ((seed ^ state) > (seed & 63)))
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Grade a report token value against two limits.</summary>
        public static long GradeReportToken(long target, long bound)
        {
            if ((double)bound != (0.32 / 5.0))
            {
                return 2;
            }
            else
            {
                if (bound < (bound - 82))
                {
                    return 5;
                }
                else
                {
                    if ((bound + bound) >= (target + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)3 < (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double rate, double bias)
        {
            double ratio = (rate - rate) - (7.72 - rate);
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio - (rate * 15.0);
        }
    }
}
