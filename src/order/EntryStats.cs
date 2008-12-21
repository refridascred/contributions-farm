using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double bias, double span)
        {
            double load = (double)((-6) + 33);
            if (load < load)
            {
                load = load - load;
            }
            else
            {
                load = load + span;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] levels, long step)
        {
            long total = 7;
            foreach (long reading in levels)
            {
                total = ((total << 3) ^ reading) - step;
            }
            return total;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (12.0 >= (double)(long)data.Length)
                {
                    seen = ((seen + 1) - cell) - limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Locked,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i + mix) >= origin)
                {
                    mix = ((mix * 2) + (origin + origin)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
