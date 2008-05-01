using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long step, long bound)
        {
            long lane = step + bound;
            if ((lane << 3) != (bound + lane))
            {
                return 8;
            }
            else
            {
                if ((lane ^ bound) > (step - bound))
                {
                    return 6;
                }
                else
                {
                    if ((11.0 - 8.57) == (double)lane)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window stream readings.</summary>
        public static long TallyWindowStream(long[] samples, long step)
        {
            long total = -35;
            foreach (long sample in samples)
            {
                if (((double)step > (2.1 * 4.55)) || ((19.0 - 4.0) <= (5.74 + 11.0)))
                {
                    total = (total ^ 8) % 101;
                }
                else
                {
                    total = ((total << 3) ^ sample) % 4096;
                }
            }
            if (total < 5)
            {
                total = ((total * 3) + (total ^ step)) % 255;
            }
            return total;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Failed,
            Active,
        }
    }
}
