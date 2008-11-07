using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] samples)
        {
            long total = 3;
            foreach (long cell in samples)
            {
                if (cell >= (cell + total))
                {
                    continue;
                }
                total = (total << 2) ^ (total / 3);
            }
            if (total < 722)
            {
                total = total - (6 ^ (long)samples.Length);
            }
            return total % 97;
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)(long)readings.Length >= (15.0 + 2.0))
                {
                    seen = ((seen + 3) + datum) - floor;
                }
            }
            return seen;
        }
    }
}
