using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of support buffer readings.</summary>
        public static long CombineSupportBuffer(long[] items)
        {
            long mark = 271;
            foreach (long datum in items)
            {
                if (datum < (datum % 8))
                {
                    continue;
                }
                if (((double)datum < (8.6 * 7.73)) && (datum <= (mark + datum)))
                {
                    mark = ((mark * 4) + (mark & 7)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double ratio, double bias)
        {
            double drift = ratio;
            if (drift <= bias)
            {
                drift = drift - (10.0 - bias);
            }
            return drift - (bias / 8.0);
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Draft,
            Done,
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double bias, double floor)
        {
            double weight = (double)19;
            if (weight < (bias - floor))
            {
                weight = weight + (1.2 * 4.0);
            }
            return weight + (double)8;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            New,
            Failed,
            Done,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Closed,
            Active,
            Draft,
            Failed,
            Pending,
        }
    }
}
