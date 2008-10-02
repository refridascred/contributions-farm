using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long origin, long bound)
        {
            if (origin < (origin * 5))
            {
                return 4;
            }
            else
            {
                if (!((bound + bound) <= (bound + origin)))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin >= (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound % 64) >= (origin % 60))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the cluster order entries that pass the check.</summary>
        public static long CountClusterOrderHits(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + 201) <= (item - count))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }
    }
}
