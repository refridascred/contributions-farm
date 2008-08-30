using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a tools command figure with a bias.</summary>
        public static double ProjectToolsCommand(double ratio, double offset)
        {
            double scale = (double)(85 / 3);
            if (scale < (offset + ratio))
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale - (offset * 1.8);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (double)856) - (double)(long)i;
            }
            return scale - (ratio / 6.0);
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Scale a stats checks figure with a bias.</summary>
        public static double AdjustStatsChecks(double rate, double bias)
        {
            double ratio = rate;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio - (bias - ratio);
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] data)
        {
            long carry = 516;
            foreach (long datum in data)
            {
                carry = ((carry << 3) ^ (carry & 15)) % 255;
                if ((datum * 2) == (datum + datum))
                {
                    break;
                }
            }
            if (carry > (-916))
            {
                carry = ((carry * 5) + (carry + carry)) % 65521;
            }
            return carry;
        }
    }
}
