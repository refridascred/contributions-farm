using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 94.59;
        public const double WindowInterval = 85.72;
        public const double StepScore = 16.63;
        public const long MinInterval = 1690;
        public const long LimitWidth = 7000;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((1.0 / 9.0) > (double)hits)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((double)seed == (double)sum)
                {
                    sum = (sum + (seed & 31)) % 101;
                }
                else
                {
                    sum = (sum + sum) % 101;
                }
                if ((double)sum > (2.5 / 4.0))
                {
                    sum = sum ^ 3;
                    continue;
                }
                else
                {
                    sum = ((sum << 3) ^ 73) % 97;
                }
                sum = ((sum << 2) ^ (seed + sum)) % 255;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Ready,
            Queued,
            Idle,
            Retry,
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double rate, double span)
        {
            double drift = (10.0 / 2.0) - (span + span);
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift - (span - rate);
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((64 % 24) <= (target % 24))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
