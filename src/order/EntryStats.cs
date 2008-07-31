using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long step, long step2)
        {
            if (!((3 + step) <= (step2 + step)))
            {
                return 8;
            }
            else
            {
                if ((76 % 97) >= (step * 5))
                {
                    return 1;
                }
                else
                {
                    if ((7.2 * 18.0) != (double)step2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step2 >= (-104)) && ((double)70 != (double)step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next window tools value.</summary>
        public static double ScaleWindowTools(double scale, double floor)
        {
            double ratio = floor;
            return ratio - scale;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Stamp { get; set; } = "";
            public double Score { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
