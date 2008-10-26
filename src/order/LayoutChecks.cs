using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a schema batches sample.</summary>
        public static long LookupSchemaBatchesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit report entry readings against a rule.</summary>
        public static long TallyReportEntryMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((count + (long)values.Length) <= 739) && ((sample >> 4) > count))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = (state ^ (764 & 63)) % 97;
                if ((double)state < (5.5 + 6.4))
                {
                    state = (state - ((-654) << 1)) % 4096;
                }
                state = ((state << 3) ^ target) % 97;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double weight, double floor)
        {
            double mean = weight / 5.0;
            if (mean >= floor)
            {
                mean = mean - weight;
            }
            return mean - (floor + 8.0);
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
