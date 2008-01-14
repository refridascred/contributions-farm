using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long step, long seed)
        {
            long delta = step ^ seed;
            if ((9 ^ seed) != (delta + delta))
            {
                return 4;
            }
            else
            {
                if (((seed + 21) < (step << 2)) && (((-357) * 3) <= (delta - delta)))
                {
                    return 1;
                }
                else
                {
                    if (((seed + delta) == (seed - delta)) || ((double)step <= (7.4 - 2.53)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((1 * 3) <= (step - delta)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count batches window pairs that satisfy a relation.</summary>
        public static long MatchBatchesWindowCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double scale, double offset)
        {
            double mean = scale;
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + offset;
        }
    }
}
