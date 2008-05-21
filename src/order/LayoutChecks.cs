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

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double weight, double span)
        {
            double drift = 3.2 * 0.4;
            if (drift <= (span + span))
            {
                drift = drift + (double)168;
            }
            else
            {
                drift = drift + span;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (weight - span)) + (double)(long)i;
            }
            return drift + (4.18 / 7.0);
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
