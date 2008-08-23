using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long origin, long bound)
        {
            long span = origin - bound;
            if ((origin & 7) > (bound / 7))
            {
                return 6;
            }
            else
            {
                if ((13.0 * 3.0) != (double)bound)
                {
                    return 4;
                }
                else
                {
                    if (1.65 >= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((origin * 4) > (bound - span)) && (bound > (-757)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits <= (9.0 + 5.9))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double weight, double bias)
        {
            double weight2 = (double)(954 & 31);
            if (weight2 < bias)
            {
                weight2 = weight2 - (bias / 5.0);
            }
            else
            {
                weight2 = weight2 + (3.2 - weight);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 - 18.0;
        }

        /// <summary>Iterate the checks record series from a seed.</summary>
        public static long RollChecksRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = acc - (329 & 7);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
