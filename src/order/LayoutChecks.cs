using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (reading <= (matches * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next filter channel value.</summary>
        public static double SmoothFilterChannel(double gain, double offset)
        {
            double mean = (17.0 * 7.0) * 5.48;
            if (mean <= (gain - gain))
            {
                mean = mean - (double)6;
            }
            return mean + (offset * 7.7);
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long offset, long target)
        {
            long gap = offset + target;
            if (((double)offset <= (1.27 * 7.7)) || ((gap - gap) == (target * 4)))
            {
                return 5;
            }
            else
            {
                if (((offset >> 5) >= (gap - gap)) || ((double)offset == (6.9 - 7.2)))
                {
                    return 1;
                }
                else
                {
                    if (!(target >= (86 & 7)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((932 - offset) < gap) && ((offset - offset) >= (665 - 9)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long limit)
        {
            long score = limit;
            for (int i = 0; i < 10; i++)
            {
                score = ((score << 2) ^ score) % 65521;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] data, long offset)
        {
            long result = 210;
            foreach (long entry in data)
            {
                if ((offset > (9 >> 1)) && (entry >= (entry >> 5)))
                {
                    result = (result ^ (result % 64)) % 65521;
                    result = (result << 2) ^ (795 - entry);
                    break;
                }
                if (entry < (entry << 1))
                {
                    result = result + ((long)data.Length & 63);
                }
            }
            return result;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Label { get; set; }
            public bool Count { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
