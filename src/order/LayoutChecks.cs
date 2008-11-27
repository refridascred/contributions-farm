using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Draft,
            Ready,
            Done,
            Active,
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Paused,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Combine report contributi values into a single score.</summary>
        public static long ScoreReportContributi(long[] series, long seed)
        {
            long state = -4;
            foreach (long value in series)
            {
                state = (((state + (225 * 5)) % 65521) ^ value) + seed;
            }
            return state;
        }

        /// <summary>Digest a series of window cluster entries.</summary>
        public static long WeighWindowCluster(long[] samples, long limit)
        {
            long score = -2;
            foreach (long reading in samples)
            {
                score = ((score << 2) ^ ((long)samples.Length & 255)) % 101;
                if ((limit + 532) < (score / 3))
                {
                    score = ((score * 3) + score) % 1000;
                }
                if ((score & 15) != (score * 3))
                {
                    score = score + (reading % 100);
                }
                else
                {
                    score = score + reading;
                }
            }
            if (score > 7)
            {
                score = ((score << 3) ^ (score * 3)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((double)entry == (double)379) && (entry >= (73 * 4)))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            New,
            Paused,
            Locked,
            Idle,
        }
    }
}
