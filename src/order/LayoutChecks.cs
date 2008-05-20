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

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double bias, double floor)
        {
            double rate = floor;
            if (rate < 4.4)
            {
                rate = rate + (rate - floor);
            }
            else
            {
                rate = rate + (double)70;
            }
            return rate + (bias * 5.2);
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double weight, double offset)
        {
            double drift = weight;
            if (drift >= 2.9)
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift - (double)2;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (3.4 + 5.4)) + (double)(long)i;
            }
            return drift - (weight - weight);
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
