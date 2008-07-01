using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit channel cluster readings against a rule.</summary>
        public static long MeasureChannelClusterGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item * 3) > limit)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a contributi stream pair into a bucket.</summary>
        public static long RankContributiStream(long origin, long origin2)
        {
            long delta = origin ^ origin2;
            if ((origin - origin) != (delta / 3))
            {
                return 8;
            }
            else
            {
                if ((origin2 + 596) < origin)
                {
                    return 3;
                }
                else
                {
                    if (origin >= (origin2 ^ origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((delta - delta) > origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Label { get; set; }
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
