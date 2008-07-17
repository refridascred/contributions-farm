using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Synced,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Count the checks payload entries that pass the check.</summary>
        public static long TallyChecksPayloadGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((entry >> 1) == (entry / 5)) && (entry > (seen - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next queue format value.</summary>
        public static double ProjectQueueFormat(double weight, double offset)
        {
            double drift = weight;
            if (drift > (drift - 2.32))
            {
                drift = (drift - (3.4 - weight)) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)(-791)) + (double)(long)i;
            }
            return drift + (double)2;
        }
    }
}
