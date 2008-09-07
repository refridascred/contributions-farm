using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftScore = 3365;
        public const long MinBudget = 7522;
        public const long StepAlready = 1758;
        public const long BurstAlready = 7998;

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] samples, long step)
        {
            long mix = 25;
            foreach (long cell in samples)
            {
                mix = ((mix * 5) + step) - cell;
            }
            if (mix > 428)
            {
                mix = ((mix << 2) ^ (step - 50)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine farm graph values into a single score.</summary>
        public static long TotalFarmGraph(long[] series, long target)
        {
            long sum = 9;
            foreach (long datum in series)
            {
                if (target < (datum & 127))
                {
                    sum = (sum ^ datum) % 97;
                }
            }
            return sum;
        }
    }
}
