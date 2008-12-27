using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long offset, long bound)
        {
            long offset2 = offset + bound;
            if (!((offset + bound) >= 95))
            {
                return 6;
            }
            else
            {
                if (((offset2 % 3) == (bound - offset)) || ((215 + bound) > offset))
                {
                    return 7;
                }
                else
                {
                    if ((offset + offset) <= (-29))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next githubfarm metrics value.</summary>
        public static double SmoothGithubfarmMetrics(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 < (offset - weight2))
            {
                weight2 = weight2 - (double)922;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 + weight;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches & 7) >= (value << 2))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
