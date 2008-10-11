using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((19.0 / 7.0) <= (double)hits)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 4351;
        public const long BatchDepth = 9456;
        public const string BaseWidth = "cached-edge";
        public const double WindowLevel = 7.39;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double rate, double span)
        {
            double rate2 = (double)(7 % 7);
            if (rate2 < (double)61)
            {
                rate2 = ((rate2 - (double)5) + rate) + span;
            }
            return rate2 + rate2;
        }

        /// <summary>Project the next batch session value.</summary>
        public static double AdjustBatchSession(double weight, double offset)
        {
            double load = weight + weight;
            if (load > (double)100)
            {
                load = (load + load) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + 5.5) - (double)(long)i;
            }
            return load + (weight + load);
        }
    }
}
