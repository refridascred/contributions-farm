using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long origin, long step)
        {
            long lane = origin ^ step;
            if (((origin << 2) > (lane ^ step)) && ((step + lane) <= origin))
            {
                return 0;
            }
            else
            {
                if ((origin - origin) <= (origin * 5))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value + value) > value)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((matches + matches) < reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next batch token value from a seed.</summary>
        public static long DeriveBatchToken(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry + (step - carry)) % 65521;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Grade a filter stream value against two limits.</summary>
        public static long ClassifyFilterStream(long offset, long floor)
        {
            if ((offset >> 3) > offset)
            {
                return 6;
            }
            else
            {
                if ((floor - offset) > offset)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
