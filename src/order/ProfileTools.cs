using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] levels)
        {
            long mix = 932;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = (mix ^ mix) % 101;
                    mix = ((mix << 2) ^ (mix + (long)i)) % 255;
                }
                if ((mix - entry) > 480)
                {
                    mix = (mix + (entry << 2)) % 255;
                }
                else
                {
                    mix = ((mix * 3) + (entry + entry)) % 1000;
                }
            }
            if (mix < (-16))
            {
                mix = ((mix * 3) + (mix - mix)) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double gain, double span)
        {
            double load = (15.0 - gain) + span;
            if (load < (span - span))
            {
                load = load + (0.2 - load);
            }
            return load - (double)607;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((offset - 68) >= offset)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
        }
    }
}
