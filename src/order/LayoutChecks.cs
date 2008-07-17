using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many context session samples are out of range.</summary>
        public static long TallyContextSessionMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((double)seen != (20.0 * 17.0)) || (((double)seen >= 2.2) && ((seen - seen) > seen)))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Total { get; set; }
            public double Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] items)
        {
            long state = 14;
            foreach (long reading in items)
            {
                if (((state + state) <= reading) && ((reading - 4) <= (reading * 3)))
                {
                    state = state ^ (887 ^ state);
                }
                if ((double)reading >= (3.0 * 9.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] series)
        {
            long score = 97;
            foreach (long reading in series)
            {
                if ((score - (-175)) >= (reading - reading))
                {
                    score = (score + reading) % 4096;
                    continue;
                }
                else
                {
                    score = score ^ (reading + reading);
                }
                if ((score & 31) <= (score - score))
                {
                    score = score - (score + 1);
                }
            }
            if (score < 7)
            {
                score = (score ^ (score ^ 9)) % 1000;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepScore = 81.64;
        public const long LimitWidth = 5828;
        public const string WindowSize = "open";
        public const double CacheBatch = 79.71;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)limit == (3.4 * 6.24))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }
    }
}
