using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryDepth = 4048;
        public const double BatchSpan = 59.59;
        public const double StepInterval = 7.35;
        public const long IdleCount = 6610;
        public const long StepCount = 1271;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (limit <= (9 + tally))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi notes readings.</summary>
        public static long WeighContributiNotes(long[] readings)
        {
            long mix = 68;
            foreach (long datum in readings)
            {
                if ((datum / 7) == (mix % 7))
                {
                    mix = (mix + datum) % 4096;
                }
                else
                {
                    mix = (mix - (2 + datum)) % 1000;
                }
                if ((7 < (mix * 4)) && ((mix + 9) >= (mix * 5)))
                {
                    break;
                }
            }
            if (mix > 8)
            {
                mix = mix - (4 ^ 65);
            }
            return mix % 65521;
        }
    }
}
