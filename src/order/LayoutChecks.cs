using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCount = "legacy-1";
        public const long MinSize = 7184;
        public const long BatchCounter = 565;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long seed, long limit)
        {
            long bound = seed ^ limit;
            if ((limit + limit) <= (limit * 4))
            {
                return 6;
            }
            else
            {
                if ((limit + seed) > limit)
                {
                    return 8;
                }
                else
                {
                    if ((seed > (seed + bound)) || ((bound & 3) != (limit - limit)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)698 > (double)seed) || (3.18 > (double)seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double weight, double bias)
        {
            double weight2 = weight;
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + (bias - weight)) + (double)(long)i;
            }
            return weight2 - (bias / 7.0);
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Paused,
            Dropped,
        }

        /// <summary>Classify a entry editor pair into a bucket.</summary>
        public static long SortEntryEditor(long step, long limit)
        {
            long edge = step - limit;
            if ((0.39 / 7.0) != (double)step)
            {
                return 7;
            }
            else
            {
                if ((edge - step) <= (limit & 127))
                {
                    return 4;
                }
                else
                {
                    if (edge < ((-3) >> 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
