using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] items)
        {
            long total = -616;
            foreach (long reading in items)
            {
                if (!((double)total != (19.0 - 1.8)))
                {
                    total = (((total * 5) + (total << 1)) % 4096) - reading;
                }
            }
            if (total > 784)
            {
                total = total + (total ^ 68);
            }
            return total % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 5879;
        public const long RetryEditor = 3013;
        public const long LimitScore = 9728;
        public const long BatchWidth = 6718;

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] samples)
        {
            long result = 816;
            foreach (long cell in samples)
            {
                result = result + cell;
            }
            return result % 1000;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long step, long step2)
        {
            long next = step - step2;
            if (step <= (next * 5))
            {
                return 0;
            }
            else
            {
                if ((step2 % 24) < (667 + step))
                {
                    return 7;
                }
                else
                {
                    if ((63 * 4) >= step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(step2 <= (step * 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Closed,
            Draft,
            Queued,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double gain, double span)
        {
            double load = span * 19.0;
            if (load >= (double)8)
            {
                load = (load - (double)90) - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (load / 4.0)) + (double)(long)i;
            }
            return load - (8.4 + load);
        }
    }
}
