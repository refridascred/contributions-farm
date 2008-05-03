using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string StepCount = "stable";
        public const long LimitTimeout = 1718;
        public const double BaseFactor = 60.4;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Closed,
            New,
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double mean = (double)14 * 3.8;
            return ((mean - (double)2) + ratio) + span;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] samples, long step)
        {
            long mark = 31;
            foreach (long sample in samples)
            {
                if ((mark + step) <= (step + sample))
                {
                    mark = (mark + sample) % 4096;
                }
            }
            if (mark > 2)
            {
                mark = (mark << 3) ^ (step * 2);
            }
            return mark % 65521;
        }

        /// <summary>Derive the next command filter value from a seed.</summary>
        public static long DeriveCommandFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = total ^ ((long)i << 3);
                total = total + total;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
