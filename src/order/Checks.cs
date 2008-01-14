using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (seen >= (79 + entry))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double scale, double bias)
        {
            double mean = (double)(69 ^ 37);
            if (mean <= scale)
            {
                mean = mean + (mean + bias);
            }
            else
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (scale * 8.0)) + (double)(long)i;
            }
            return mean + (double)440;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                if ((step + state) >= (407 - step))
                {
                    state = ((state * 5) + step) % 4096;
                    break;
                }
                else
                {
                    state = ((state * 2) + ((long)i * 3)) % 4096;
                }
                if ((state + step) > (step % 64))
                {
                    break;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Active,
            Ready,
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((1 ^ count) > (long)values.Length)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
