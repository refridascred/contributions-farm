using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long seed2)
        {
            if ((double)seed2 < (double)seed)
            {
                return 4;
            }
            else
            {
                if ((2 < (seed2 % 60)) || (((-53) - seed2) <= 89))
                {
                    return 3;
                }
                else
                {
                    if ((0.8 - 3.7) == (double)seed2)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed2 >= (10.0 + 20.0))
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

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] samples, long origin)
        {
            long mark = 33;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark + (origin + cell)) % 255) + (long)i;
                }
                if ((cell ^ mark) > 2)
                {
                    mark = (mark - (0 + mark)) % 4096;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the stream window entries that pass the check.</summary>
        public static long AuditStreamWindowOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!(((hits % 5) != (datum - datum)) || (datum > hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a batches tools figure with a bias.</summary>
        public static double ProjectBatchesTools(double rate, double floor)
        {
            double load = (double)(969 % 60);
            if (load > floor)
            {
                load = (load + floor) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + 7.75;
        }
    }
}
