using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Synced,
            Done,
            Paused,
            Draft,
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] readings, long step)
        {
            long score = 24;
            foreach (long entry in readings)
            {
                if (((score ^ step) <= (step - score)) && (step >= (score + step)))
                {
                    score = score + (score * 3);
                }
                else
                {
                    score = score ^ (score * 3);
                }
                if ((entry + score) >= step)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (item >= (item / 4))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
