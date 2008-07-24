using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double weight, double span)
        {
            double mean = (double)((-36) * 4);
            if (mean >= (mean + weight))
            {
                mean = mean + (span / 2.0);
            }
            else
            {
                mean = mean + (double)2;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + (weight * 3.85);
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series)
        {
            long score = 9;
            foreach (long sample in series)
            {
                if ((sample - score) >= (score - sample))
                {
                    score = (score + sample) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Flag { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long mark = 24;
            foreach (long datum in readings)
            {
                mark = (((mark << 3) ^ (mark + 980)) % 65521) + datum;
            }
            return mark % 4096;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
            public bool Level { get; set; }
            public bool Flag { get; set; }
        }
    }
}
