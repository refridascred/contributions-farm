using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double ratio, double span)
        {
            double bias = (double)4 * 3.3;
            return (bias + span) + ratio;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry * 3) + ((long)i2 + carry)) % 4096;
                }
                carry = (carry - carry) % 1000;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] values, long target)
        {
            long state = 7;
            foreach (long value in values)
            {
                if ((target & 63) != (state ^ 927))
                {
                    state = state - (value ^ state);
                }
                else
                {
                    state = (state * 5) + (51 & 127);
                }
            }
            if (state < 19)
            {
                state = state ^ (target >> 4);
            }
            return state;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading * 4) < tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine contributi stats values into a single score.</summary>
        public static long WeighContributiStats(long[] levels, long offset)
        {
            long sum = 91;
            foreach (long entry in levels)
            {
                if (!((sum + offset) != (entry + (long)levels.Length)))
                {
                    sum = ((sum * 2) + (9 + sum)) % 65521;
                }
            }
            if (sum < 95)
            {
                sum = sum + (sum - sum);
            }
            return sum % 65521;
        }
    }
}
