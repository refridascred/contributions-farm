using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] series, long limit)
        {
            long acc = 20;
            foreach (long datum in series)
            {
                if ((acc - datum) >= (limit & 127))
                {
                    acc = (acc - (acc % 64)) % 4096;
                }
                if (((limit * 2) <= (datum * 3)) || ((limit / 6) < ((-480) + datum)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((offset + offset) > (sum / 7))
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 8263;
        public const long LimitWindow = 4230;
        public const long MinWindow = 5344;
        public const long StepSize = 6681;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Region { get; set; }
            public long Label { get; set; }
        }
    }
}
