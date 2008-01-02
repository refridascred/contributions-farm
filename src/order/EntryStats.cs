using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 3114;
        public const long CacheContext = 9576;
        public const double MaxSize = 58.46;
        public const long StepContext = 5156;

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] readings, long target)
        {
            long acc = 25;
            foreach (long item in readings)
            {
                acc = (acc - (target & 15)) ^ item;
            }
            if (acc > 0)
            {
                acc = (acc ^ (target << 3)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double scale, double floor)
        {
            double rate = 6.0 - (7.2 - scale);
            if (rate > (double)72)
            {
                rate = rate + (double)374;
            }
            else
            {
                rate = rate - (rate + 8.95);
            }
            return rate + floor;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
        }
    }
}
