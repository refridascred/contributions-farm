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

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((value * 2) == (86 - hits)) && ((hits - hits) <= (hits * 3)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
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
