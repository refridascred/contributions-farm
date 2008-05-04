using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double weight = span;
            if (weight < span)
            {
                weight = weight - (double)29;
            }
            else
            {
                weight = weight - (gain / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (gain * 12.0)) + (double)(long)i;
            }
            return weight + (double)71;
        }

        /// <summary>Audit entry filter readings against a rule.</summary>
        public static long TallyEntryFilterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches - (-776)) <= (matches << 1))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
