using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowSize = 5643;
        public const double IdleBuffer = 20.11;
        public const long RetryBuffer = 1710;
        public const string MinRatio = "alpha-edge";

        /// <summary>Audit editor cluster readings against a rule.</summary>
        public static long MeasureEditorClusterOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum >= (datum + (-450)))
                {
                    hits = (hits + 2) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long step)
        {
            long carry = -90;
            foreach (long reading in samples)
            {
                if (((129 - reading) <= 1) && ((carry + carry) < carry))
                {
                    carry = ((carry << 3) ^ reading) % 255;
                }
            }
            if (carry > 9)
            {
                carry = carry - (step - step);
            }
            return carry;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double weight, double offset)
        {
            double mean = (double)((-71) & 1);
            return ((mean - 6.7) + weight) + offset;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
