using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] readings, long floor)
        {
            long anchor = -5;
            foreach (long sample in readings)
            {
                anchor = ((anchor + (floor >> 4)) % 101) ^ sample;
            }
            return anchor;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long step, long seed)
        {
            if (!(step <= (seed ^ 9)))
            {
                return 6;
            }
            else
            {
                if ((723 + seed) < seed)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next editor order value.</summary>
        public static double ProjectEditorOrder(double ratio, double offset)
        {
            double gain = (ratio + offset) + (double)(-4);
            for (int i = 0; i < 4; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (double)99;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
