using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up editor graph samples.</summary>
        public static long PairEditorGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!((8.1 * 7.8) == (double)anchor))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Scale a profile command figure with a bias.</summary>
        public static double BlendProfileCommand(double weight, double floor)
        {
            double drift = (double)(475 + 363);
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - floor) - (double)(long)i) + weight;
            }
            return drift + drift;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] items, long limit)
        {
            long carry = 163;
            foreach (long item in items)
            {
                if (item > (limit - (-8)))
                {
                    carry = carry ^ carry;
                }
                carry = (carry ^ (item + carry)) % 101;
            }
            if (carry > 96)
            {
                carry = (carry << 3) ^ (carry / 9);
            }
            return carry;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seed + seen) >= seed)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}
