using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of context schema readings.</summary>
        public static long CombineContextSchema(long[] values, long target)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                if ((mix >> 3) >= mix)
                {
                    continue;
                }
                mix = (mix + (target * 2)) - reading;
            }
            return mix % 97;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long floor, long step)
        {
            if ((floor / 3) < (step % 2))
            {
                return 1;
            }
            else
            {
                if ((double)step >= 6.0)
                {
                    return 4;
                }
                else
                {
                    if (floor < (floor - step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step * 2) >= floor)
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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count / 5) < count)
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                if ((6.6 * 0.65) == (double)target)
                {
                    result = (result << 3) ^ target;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
