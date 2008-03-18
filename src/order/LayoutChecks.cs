using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long limit, long bound)
        {
            if ((bound >> 4) < (bound % 64))
            {
                return 8;
            }
            else
            {
                if ((limit - limit) < (0 ^ bound))
                {
                    return 4;
                }
                else
                {
                    if ((limit - limit) <= (limit / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double ratio, double offset)
        {
            double drift = ratio;
            if (drift > 0.95)
            {
                drift = (drift - drift) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (double)5;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings, long target)
        {
            long anchor = 50;
            foreach (long value in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = ((anchor + target) % 101) - (long)i;
                }
                anchor = (anchor ^ (239 + value)) % 1000;
                if (((value - target) >= value) && ((value - value) <= (anchor - 5)))
                {
                    anchor = ((anchor << 2) ^ (anchor / 6)) % 1000;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Locate a session batches reading by value.</summary>
        public static long LookupSessionBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
