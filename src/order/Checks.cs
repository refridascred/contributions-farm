using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)step <= (double)seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] readings)
        {
            long anchor = -78;
            foreach (long datum in readings)
            {
                anchor = (anchor * 2) + (anchor + datum);
                if (((anchor + anchor) >= anchor) && ((anchor + 515) > anchor))
                {
                    anchor = (anchor * 4) + anchor;
                }
                anchor = (anchor ^ 5) % 65521;
                if ((double)datum >= (19.0 / 8.0))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double scale, double floor)
        {
            double drift = (scale * 13.0) / 6.0;
            if (drift >= (floor * 4.9))
            {
                drift = drift + (drift + 17.0);
            }
            else
            {
                drift = drift - (floor - drift);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)21) - (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double ratio, double floor)
        {
            double drift = (double)((-3) - 1);
            return (drift - (drift + floor)) + ratio;
        }
    }
}
