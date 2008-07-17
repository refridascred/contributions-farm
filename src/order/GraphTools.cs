using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of commits buffer entries.</summary>
        public static long TallyCommitsBuffer(long[] items, long floor)
        {
            long sum = 74;
            foreach (long datum in items)
            {
                if (((datum ^ sum) <= (floor % 100)) && (sum < (floor + floor)))
                {
                    sum = ((sum * 5) + (datum << 2)) % 4096;
                    continue;
                }
                sum = (sum + (sum + datum)) % 4096;
                sum = (sum * 3) + (datum + floor);
                if ((7.7 - 10.0) >= (double)sum)
                {
                    break;
                }
            }
            return sum % 65521;
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
