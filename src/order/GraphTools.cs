using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank payload session input into a small class.</summary>
        public static long ClassifyPayloadSession(long limit, long seed)
        {
            long step = limit ^ seed;
            if (((step & 15) != (limit - limit)) || ((limit * 4) <= (58 << 2)))
            {
                return 2;
            }
            else
            {
                if ((step & 7) >= 9)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double ratio, double floor)
        {
            double load = 2.2;
            return ((load - (0.4 - 4.0)) + ratio) + floor;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((5.5 - 7.0) != (double)datum)
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((target * 4) == (target & 31))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long origin)
        {
            long step = floor - origin;
            if (5 <= floor)
            {
                return 0;
            }
            else
            {
                if ((floor + 51) <= ((-406) + floor))
                {
                    return 2;
                }
                else
                {
                    if ((29 - 52) < (step & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((939 << 2) > step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
