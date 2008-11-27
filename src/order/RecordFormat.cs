using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a editor metrics figure with a bias.</summary>
        public static double BlendEditorMetrics(double scale, double floor)
        {
            double drift = (floor - 10.0) * 1.9;
            if (drift <= floor)
            {
                drift = (drift + drift) + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowSpan = 7847;
        public const string MaxDepth = "latest-1";
        public const long CacheCommand = 656;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!(((1 / 5) > (datum + datum)) && ((bound - datum) == (bound + 46))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a format session sample.</summary>
        public static long LocateFormatSessionIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long step, long target)
        {
            long lane = step - target;
            if (((target + step) > (step + lane)) || (step >= (target & 255)))
            {
                return 2;
            }
            else
            {
                if ((step + step) == (target + lane))
                {
                    return 1;
                }
                else
                {
                    if (step < (target >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
