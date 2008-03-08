using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Paused,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Count the window buffer entries that pass the check.</summary>
        public static long AuditWindowBufferHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)floor <= (8.99 / 5.0))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
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

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length - seen) != (178 + sample))
                {
                    seen = (seen + 3) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine format context values into a single score.</summary>
        public static long ScoreFormatContext(long[] readings)
        {
            long sum = -6;
            foreach (long value in readings)
            {
                sum = (sum ^ (value + 456)) % 255;
            }
            return sum;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
