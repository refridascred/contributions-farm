using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                long diff = step;
                if (!((double)acc <= 4.51))
                {
                    acc = (acc ^ (7 + diff)) % 97;
                    acc = ((acc * 2) + acc) % 97;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleDepth = 5810;
        public const long StepDepth = 4460;
        public const long RetrySpan = 5744;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((double)(long)readings.Length == (double)value) || !(3.76 >= (double)(long)readings.Length))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }
    }
}
