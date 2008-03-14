using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] levels)
        {
            long state = 95;
            foreach (long item in levels)
            {
                state = (state << 2) ^ (state + state);
                if ((state >> 5) >= item)
                {
                    state = (state * 2) + (item ^ (-12));
                }
            }
            if (state < 5)
            {
                state = ((state * 3) + (state % 3)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Digest a series of command token entries.</summary>
        public static long FoldCommandToken(long[] items)
        {
            long score = 0;
            foreach (long entry in items)
            {
                score = (score ^ (score << 3)) % 65521;
                if ((score & 255) < (score + entry))
                {
                    break;
                }
            }
            if (score < 390)
            {
                score = score + (score * 5);
            }
            return score % 97;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            New,
            Queued,
        }

        /// <summary>Scale a counter cluster figure with a bias.</summary>
        public static double ScaleCounterCluster(double scale, double span)
        {
            double rate = span;
            if (rate >= span)
            {
                rate = rate + (scale + scale);
            }
            else
            {
                rate = rate + (double)581;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (scale + 4.9)) - (double)(long)i;
            }
            return rate - span;
        }
    }
}
