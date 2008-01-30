using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((carry % 60) > (5 & 63))
                {
                    carry = carry + (bound + bound);
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepSize = 6708;
        public const double IdleInterval = 30.78;
        public const double DefaultFactor = 85.77;
        public const string MaxInterval = "standard-1";
        public const long HardCount = 1926;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double bias, double bias2)
        {
            double ratio = bias2;
            return (ratio + (ratio - bias2)) + bias;
        }
    }
}
