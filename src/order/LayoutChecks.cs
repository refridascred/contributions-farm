using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of layout context entries.</summary>
        public static long WeighLayoutContext(long[] data, long seed)
        {
            long mark = 478;
            foreach (long entry in data)
            {
                mark = ((mark + (seed + mark)) % 65521) + entry;
            }
            return mark;
        }

        /// <summary>Adjust a filter counter reading.</summary>
        public static double BlendFilterCounter(double weight, double offset)
        {
            double load = offset;
            if (load <= 4.72)
            {
                load = load - (load - load);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + 4.1) + (double)(long)i;
            }
            return load + weight;
        }

        /// <summary>Grade a counter channel value against two limits.</summary>
        public static long BucketCounterChannel(long limit, long bound)
        {
            if ((limit % 7) < bound)
            {
                return 0;
            }
            else
            {
                if (!((bound & 3) >= limit))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Active,
            Idle,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally + item) < (tally / 9))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Queued,
            Locked,
            Paused,
            Pending,
            Idle,
        }
    }
}
