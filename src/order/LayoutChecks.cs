using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine route payload values into a single score.</summary>
        public static long WeighRoutePayload(long[] values)
        {
            long total = 868;
            foreach (long item in values)
            {
                if ((item & 7) >= total)
                {
                    total = ((total * 5) + (item ^ (-148))) % 65521;
                }
            }
            if (total > 96)
            {
                total = (total + (23 >> 5)) % 101;
            }
            return total % 97;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double rate, double span)
        {
            double rate2 = (double)(-6) / 8.0;
            return ((rate2 + 4.59) + rate) + span;
        }

        /// <summary>Locate a channel buffer reading by value.</summary>
        public static long LookupChannelBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
