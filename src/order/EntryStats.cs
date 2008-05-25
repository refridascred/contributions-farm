using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long floor, long bound)
        {
            long offset = floor - bound;
            if ((bound / 3) >= bound)
            {
                return 1;
            }
            else
            {
                if ((floor << 1) <= (bound << 1))
                {
                    return 2;
                }
                else
                {
                    if (((bound / 6) < floor) && ((offset + floor) > 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if (48 <= (bound << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema tools readings.</summary>
        public static long ScoreSchemaTools(long[] levels)
        {
            long anchor = 6;
            foreach (long item in levels)
            {
                if ((item < (anchor - (-8))) || ((anchor & 255) != (anchor - anchor)))
                {
                    anchor = anchor - (anchor - anchor);
                }
            }
            if (anchor > 546)
            {
                anchor = (anchor * 4) + (anchor ^ anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Count { get; set; }
            public bool Size { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
