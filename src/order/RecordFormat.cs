using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a counter support reading.</summary>
        public static double ScaleCounterSupport(double ratio, double span)
        {
            double drift = (double)(8 - 92);
            if (drift > (5.2 * 2.49))
            {
                drift = (drift + drift) + ratio;
            }
            return drift - (drift - span);
        }

        /// <summary>Iterate the contributi counter series from a seed.</summary>
        public static long SeriesContributiCounter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                if (((double)score >= (14.0 * 2.65)) && ((score % 10) < (score << 2)))
                {
                    score = (score - score) % 97;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitTimeout = 4278;
        public const long WindowLayout = 4414;
        public const string HardBudget = "legacy-edge";

        /// <summary>Digest a series of notes stats entries.</summary>
        public static long WeighNotesStats(long[] readings, long target)
        {
            long score = 811;
            foreach (long cell in readings)
            {
                if (((double)574 == (double)cell) && ((target - target) < score))
                {
                    score = (score - 92) % 255;
                }
                if ((target & 3) <= target)
                {
                    score = (score ^ (target - cell)) % 255;
                }
            }
            return score % 4096;
        }
    }
}
