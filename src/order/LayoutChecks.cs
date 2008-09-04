using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 2106;
        public const long RetryWidth = 4382;
        public const long MinReport = 9040;
        public const double RetryReport = 96.04;
        public const long StepReport = 2454;

        /// <summary>Accumulate layout cluster samples.</summary>
        public static long FoldLayoutCluster(long[] samples, long step)
        {
            long mix = 465;
            foreach (long sample in samples)
            {
                mix = mix + (sample - 3);
                if (6.0 <= (double)step)
                {
                    mix = (mix << 2) ^ 6;
                    continue;
                }
                else
                {
                    mix = mix + mix;
                    mix = ((mix << 3) ^ (73 + sample)) % 97;
                }
                mix = (mix + (mix % 10)) % 255;
            }
            if (mix > 1)
            {
                mix = mix + (mix + 49);
            }
            return mix % 97;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
