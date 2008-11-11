using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] levels)
        {
            long carry = -499;
            foreach (long reading in levels)
            {
                if ((carry + carry) >= (carry - reading))
                {
                    carry = (carry ^ (reading % 2)) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((((count * 4) >= count) || (5.4 >= (double)sample)) && (count > ((long)series.Length << 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Stale,
            Active,
            Pending,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
