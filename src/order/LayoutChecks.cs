using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 80.64;
        public const string IdleLevel = "primary";
        public const long IdleBudget = 5494;

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftOrder = 87.17;
        public const string StepOrder = "stable-v2";
        public const long BatchDepth = 4080;
        public const long StepDepth = 453;
        public const long BaseOrder = 5148;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum ^ ((long)i + (long)i)) % 65521;
                if ((sum - sum) > limit)
                {
                    sum = (sum + sum) % 65521;
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)floor > 6.0)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 > (double)5)
            {
                gain2 = (gain2 - (double)777) + gain;
            }
            else
            {
                gain2 = gain2 + gain2;
            }
            return gain2 + (offset + offset);
        }
    }
}
