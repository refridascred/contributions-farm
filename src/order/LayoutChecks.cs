using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double rate, double offset)
        {
            double drift = rate;
            if (drift < (17.0 - drift))
            {
                drift = drift - (drift - offset);
            }
            else
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift - (drift * 7.0);
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long step, long seed)
        {
            if ((step < (step << 2)) || (step >= (step + 22)))
            {
                return 2;
            }
            else
            {
                if ((seed >> 1) < (seed & 255))
                {
                    return 1;
                }
                else
                {
                    if ((double)step >= (double)978)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)step != (5.0 - 3.0)) || (seed < (seed * 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the channel command entries that pass the check.</summary>
        public static long MeasureChannelCommandOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)item > (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the route metric entries that pass the check.</summary>
        public static long CountRouteMetricOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count << 1) < (count / 5))
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
