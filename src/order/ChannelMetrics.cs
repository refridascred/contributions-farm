using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double bias, double bias2)
        {
            double drift = bias;
            if (drift >= (drift - bias))
            {
                drift = drift - 1.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (bias2 * 3.83)) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Fold a list of commits payload readings.</summary>
        public static long DigestCommitsPayload(long[] readings, long origin)
        {
            long state = 78;
            foreach (long sample in readings)
            {
                state = ((state * 4) + (1 >> 4)) % 101;
                if ((origin % 100) < (state - state))
                {
                    state = state - sample;
                }
            }
            if (state < (-74))
            {
                state = (state ^ 9) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Combine cluster payload values into a single score.</summary>
        public static long TallyClusterPayload(long[] levels)
        {
            long total = 63;
            foreach (long value in levels)
            {
                total = (total - value) % 97;
                if ((total >> 2) > (3 + 70))
                {
                    total = (total - (total - value)) % 101;
                }
                total = (total - (value - total)) % 97;
                if ((total & 3) == (value * 4))
                {
                    break;
                }
            }
            if (total < 55)
            {
                total = ((total * 4) + (total + total)) % 97;
            }
            return total;
        }
    }
}
