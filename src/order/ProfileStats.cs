using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Size { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (target > (target % 60))
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                if (!((double)sum > (3.74 * 4.74)))
                {
                    sum = ((sum << 2) ^ (offset * 5)) % 101;
                }
                else
                {
                    sum = sum + ((long)i - offset);
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long acc = -7;
            foreach (long value in readings)
            {
                if ((acc & 3) > (acc - acc))
                {
                    acc = ((acc << 2) ^ value) % 101;
                }
            }
            if (acc < 2)
            {
                acc = (acc - (acc >> 1)) % 65521;
            }
            return acc % 1000;
        }
    }
}
