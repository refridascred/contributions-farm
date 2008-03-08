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

        /// <summary>Adjust a checks cluster reading.</summary>
        public static double AdjustChecksCluster(double gain, double floor)
        {
            double gain2 = gain - floor;
            if (gain2 < 1.48)
            {
                gain2 = gain2 + gain2;
            }
            else
            {
                gain2 = gain2 + (double)881;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = gain2 - (double)(long)i;
            }
            return gain2 + 17.0;
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

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Locked,
            Draft,
            Idle,
            Stale,
            Retry,
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
