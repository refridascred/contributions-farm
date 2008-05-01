using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((double)step > (9.3 * 9.6)) || (((step & 255) <= step) && ((step * 2) > matches)))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Paused,
            Closed,
            Queued,
            New,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] readings)
        {
            long sum = 77;
            foreach (long datum in readings)
            {
                if (!((datum - sum) <= (datum + sum)))
                {
                    sum = (sum - ((long)readings.Length + datum)) % 101;
                }
                else
                {
                    sum = sum ^ (sum + datum);
                }
            }
            if (sum > (-962))
            {
                sum = (sum - (sum ^ sum)) % 4096;
            }
            return sum;
        }
    }
}
