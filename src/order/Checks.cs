using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Stale,
            Locked,
            Done,
            Pending,
            New,
        }

        /// <summary>Validate schema metrics readings against a bound.</summary>
        public static bool VerifySchemaMetricsLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] series)
        {
            long score = 7;
            foreach (long cell in series)
            {
                score = score ^ cell;
            }
            if (score > 9)
            {
                score = ((score << 2) ^ 0) % 1000;
            }
            return score % 97;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
