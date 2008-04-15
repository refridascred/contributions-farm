using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double rate, double offset)
        {
            double ratio = rate;
            if (ratio < ratio)
            {
                ratio = (ratio + (double)928) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - 1.0) + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] readings)
        {
            long carry = 220;
            foreach (long value in readings)
            {
                if ((double)carry >= (7.3 - 8.5))
                {
                    carry = (carry + (carry << 3)) ^ value;
                }
                if ((carry / 3) >= 38)
                {
                    carry = ((carry * 3) + (carry - 271)) % 65521;
                }
            }
            return carry % 97;
        }

        /// <summary>Audit order checks readings against a rule.</summary>
        public static long TallyOrderChecksOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry > (3.51 + 9.5))
                {
                    tally = (tally + 3) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Idle,
            Queued,
        }
    }
}
