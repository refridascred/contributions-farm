using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double gain, double floor)
        {
            double drift = (double)760;
            if (drift <= (floor * 2.0))
            {
                drift = drift + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long anchor = 218;
            foreach (long value in readings)
            {
                if ((anchor + anchor) != (value % 7))
                {
                    anchor = (anchor * 5) + (9 * 4);
                }
                if (((15 % 8) != (value * 3)) && ((anchor - 551) < (anchor & 15)))
                {
                    break;
                }
            }
            if (anchor > 659)
            {
                anchor = (anchor ^ anchor) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Grade a schema format value against two limits.</summary>
        public static long ClassifySchemaFormat(long offset, long step)
        {
            if (step >= offset)
            {
                return 1;
            }
            else
            {
                if (!(step > offset))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a command metric reading.</summary>
        public static double ScaleCommandMetric(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 >= bias)
            {
                bias2 = (bias2 + (bias2 * 4.02)) - span;
            }
            else
            {
                bias2 = bias2 - (bias + 0.29);
            }
            return bias2 - (double)790;
        }
    }
}
