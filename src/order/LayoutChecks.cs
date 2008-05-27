using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] values)
        {
            long mix = 26;
            foreach (long entry in values)
            {
                if ((entry & 255) > (mix + mix))
                {
                    mix = (mix ^ entry) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Validate batch session readings against a bound.</summary>
        public static bool CheckBatchSessionLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long offset, long seed)
        {
            long diff = offset ^ seed;
            if ((seed - diff) < diff)
            {
                return 1;
            }
            else
            {
                if ((double)diff < (2.35 - 7.26))
                {
                    return 2;
                }
                else
                {
                    if (diff < (diff / 9))
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

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double weight, double offset)
        {
            double gain = (double)438;
            if (gain <= (double)9)
            {
                gain = (gain - weight) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - weight) - (double)(long)i;
            }
            return gain + (weight + weight);
        }
    }
}
