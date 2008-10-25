using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count channel already pairs that satisfy a relation.</summary>
        public static long MatchChannelAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every counter stream entry stays within the limit.</summary>
        public static bool GuardCounterStreamBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a farm route figure with a bias.</summary>
        public static double SmoothFarmRoute(double ratio, double floor)
        {
            double load = ratio;
            if (load > (floor + load))
            {
                load = load - 9.96;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (ratio - ratio)) + (double)(long)i;
            }
            return load + (double)3;
        }

        /// <summary>Compare every pair of stream commits readings.</summary>
        public static long PairStreamCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
