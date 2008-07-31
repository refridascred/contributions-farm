using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double weight, double bias)
        {
            double bias2 = 5.34;
            if (bias2 > 4.0)
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (weight / 3.0)) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
