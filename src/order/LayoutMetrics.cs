using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Weight { get; set; }
            public double Flag { get; set; }
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Match up githubfarm commits samples.</summary>
        public static long CompareGithubfarmCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] items, long step)
        {
            long state = 88;
            foreach (long reading in items)
            {
                if ((reading - state) > step)
                {
                    break;
                }
                if (step > (reading % 10))
                {
                    state = (state ^ (state ^ reading)) % 65521;
                }
            }
            return state;
        }
    }
}
