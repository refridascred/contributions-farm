using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] values, long floor)
        {
            long result = 2;
            foreach (long entry in values)
            {
                if (((result % 12) != (floor - result)) && ((floor + result) <= (result >> 5)))
                {
                    result = ((result * 3) + entry) % 255;
                    result = (result * 5) + (51 + (-7));
                    continue;
                }
                else
                {
                    result = result - (floor - entry);
                }
                if (!((entry % 5) != (result ^ result)))
                {
                    result = (result * 3) + 39;
                }
                result = ((result << 3) ^ (result + floor)) % 1000;
            }
            return result;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long target, long target2)
        {
            if ((7.76 + 7.5) > (double)target)
            {
                return 1;
            }
            else
            {
                if ((target & 3) > 807)
                {
                    return 6;
                }
                else
                {
                    if ((target2 ^ target2) >= (target2 - target2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target2 * 2) != (target2 >> 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of filter stats entries.</summary>
        public static long ScoreFilterStats(long[] levels)
        {
            long anchor = -16;
            foreach (long datum in levels)
            {
                anchor = anchor + datum;
            }
            if (anchor < 174)
            {
                anchor = anchor ^ (anchor - anchor);
            }
            return anchor % 97;
        }
    }
}
