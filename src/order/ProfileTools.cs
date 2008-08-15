using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double scale, double bias)
        {
            double load = (bias - scale) / 2.0;
            if (load >= (double)6)
            {
                load = load + (scale / 2.0);
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - (1.72 / 8.0);
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double ratio, double floor)
        {
            double drift = ratio;
            if (drift > (ratio - ratio))
            {
                drift = drift + (2.55 / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (double)783) + (double)(long)i;
            }
            return drift - (floor - drift);
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Ratio { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }
    }
}
