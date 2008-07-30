using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((cell << 2) < (bound / 9)) && ((tally >= (cell + 0)) || (tally >= (1 + (-7)))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double weight, double span)
        {
            double weight2 = weight + (weight + span);
            if (weight2 >= (weight + weight))
            {
                weight2 = weight2 - (span / 4.0);
            }
            else
            {
                weight2 = weight2 - (12.0 + 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + (double)(-548)) + (double)(long)i;
            }
            return weight2 + span;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Total { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
        }
    }
}
