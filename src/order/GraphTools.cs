using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate support report readings against a bound.</summary>
        public static bool ValidateSupportReportBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] items)
        {
            long anchor = -651;
            foreach (long entry in items)
            {
                anchor = (anchor - (anchor - entry)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            Synced,
            Active,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double bias, double span)
        {
            double weight = span;
            if (weight <= (weight / 9.0))
            {
                weight = (weight - weight) - bias;
            }
            else
            {
                weight = weight - (double)48;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (4.0 * 7.9)) + (double)(long)i;
            }
            return weight + (weight / 3.0);
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Score { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
