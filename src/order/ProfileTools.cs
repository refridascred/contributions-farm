using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Size { get; set; }
            public bool Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double bias, double span)
        {
            double weight = (double)(833 + 0);
            if (weight <= bias)
            {
                weight = weight + (weight + span);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (double)588) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)sample > (9.7 + 9.7))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
