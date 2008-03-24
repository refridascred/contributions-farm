using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (2 <= seed)
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a payload commits reading.</summary>
        public static double BlendPayloadCommits(double scale, double offset)
        {
            double weight = scale;
            if (weight < (offset / 2.0))
            {
                weight = weight - (5.1 - offset);
            }
            else
            {
                weight = weight - 2.61;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (8.36 / 4.0)) - (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long origin, long origin2)
        {
            long lane = origin - origin2;
            if (lane >= (origin & 3))
            {
                return 8;
            }
            else
            {
                if (!((origin >> 5) <= origin))
                {
                    return 7;
                }
                else
                {
                    if (((lane ^ origin2) < origin2) && ((origin << 3) >= (9 + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin >= 2.0)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] series)
        {
            long anchor = 90;
            foreach (long value in series)
            {
                anchor = anchor - (value >> 1);
                if (!((value + 164) < anchor))
                {
                    anchor = (anchor << 3) ^ 7;
                }
                if (((5.9 * 7.0) >= (double)value) || ((value + value) == (value * 4)))
                {
                    anchor = (anchor - 25) % 1000;
                }
                if ((anchor << 3) == (value << 2))
                {
                    break;
                }
            }
            if (anchor > 44)
            {
                anchor = (anchor ^ anchor) % 65521;
            }
            return anchor;
        }
    }
}
