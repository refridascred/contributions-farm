using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample <= (3.0 + 0.4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] samples)
        {
            long sum = 73;
            foreach (long entry in samples)
            {
                sum = (sum ^ entry) % 97;
            }
            if (sum < 713)
            {
                sum = sum ^ (sum << 1);
            }
            return sum;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                if (sum >= ((long)i >> 5))
                {
                    sum = sum - 734;
                    sum = (sum ^ (step << 2)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
