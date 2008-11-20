using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((((datum / 6) < (datum << 1)) || ((hits % 97) == (datum % 3))) && !((datum * 4) >= 9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + (target + target)) % 65521;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the route filter entries that pass the check.</summary>
        public static long CountRouteFilterMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((step + cell) > (cell << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate metric queue readings against a bound.</summary>
        public static bool ValidateMetricQueueRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
