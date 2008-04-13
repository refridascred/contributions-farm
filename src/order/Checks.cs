using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((624 - item) <= (seen + seen))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double weight, double offset)
        {
            double load = (double)46 * 19.0;
            if (load >= (double)9)
            {
                load = load + (weight / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + weight;
        }

        /// <summary>Derive the next counter route value from a seed.</summary>
        public static long IterateCounterRoute(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc << 3) ^ (target << 1);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
